using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMarker.Dll
{

    /// <summary>
    /// 批量打印文件支持，提供统一的PrintDocument
    /// </summary>
    public class MarkPrinter
    {
        private readonly string printFolderPath;
        private readonly PrinterSettings printerSettings;

        public int CurrentPrintingNumber { get; set; }
        public int TotalPrintingNumber { get; set; }

        public MarkPrinter(string printFolderPath, PrinterSettings printerSettings)
        {
            this.printFolderPath = printFolderPath ?? throw new ArgumentNullException(nameof(printFolderPath));
            this.printerSettings = printerSettings ?? throw new ArgumentNullException(nameof(printerSettings));
        }

        public async Task<bool> PrintAsync(IProgress<ProgressPartialResult> progress)
        {
            DirectoryInfo info = new DirectoryInfo(printFolderPath);
            FileInfo[] files = info.GetFiles();
            if (files.Length == 0)
            {
                return false;
            }
            List<string> fileNameList = new List<string>();
            foreach (FileInfo file in files)
            {
                fileNameList.Add(file.FullName);
            }
            TotalPrintingNumber = fileNameList.Count;
            CurrentPrintingNumber = 1;
            foreach (string file in fileNameList)
            {
                if (progress != null)
                {
                    progress.Report(new ProgressPartialResult()
                    {
                        Current = CurrentPrintingNumber,
                        Total = TotalPrintingNumber
                    });
                }
                Document doc = new Document(file);
                await Task.Run(() => doc.Print(printerSettings));
                CurrentPrintingNumber++;
            }
            return true;
        }
    }
}

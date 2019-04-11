using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using XMarker.Dll;
using XMarker.DLL;

namespace XMarker
{
    public partial class MainForm : Form
    {
        private readonly string settingsFilePath = Application.StartupPath + @"\settings.ini";
        public bool OnPrinting { get; set; } = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            SourceFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(SourceFileDialog.FileName))
            {
                return;
            }

            SourceText.Text = SourceFileDialog.FileName;
        }

        private void TargetButton_Click(object sender, EventArgs e)
        {
            TargetFolderDialog.ShowDialog();
            if (!Directory.Exists(TargetFolderDialog.SelectedPath))
            {
                return;
            }

            TargetText.Text = TargetFolderDialog.SelectedPath;
        }

        private void MarkFontButton_Click(object sender, EventArgs e)
        {
            MarkFontDialog.ShowDialog();
            MarkFontText.Text = MarkFontDialog.Font.Name;
        }

        private void MarkColorPicture_Click(object sender, EventArgs e)
        {
            MarkColorDialog.ShowDialog();
            MarkColorPicture.BackColor = MarkColorDialog.Color;
        }

        private void AddOfficeButton_Click(object sender, EventArgs e)
        {
            string text = AddOfficeText.Text;
            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            if (OfficeList.Items.Contains(text))
            {
                return;
            }
            AddOfficeText.Clear();
            OfficeList.Items.Insert(0, AddOfficeText.Text.Trim());
            OfficeList.SelectedIndex = 0;
        }

        private void DeleteOfficeButton_Click(object sender, EventArgs e)
        {
            if (OfficeList.SelectedItem == null)
            {
                return;
            }

            OfficeList.Items.Remove(OfficeList.SelectedItem);
        }

        /// <summary>
        /// 导入单位列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportButton_Click(object sender, EventArgs e)
        {
            ListOpenDialog.ShowDialog();
            string fileName = ListOpenDialog.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }
            ImportList(fileName);
        }

        private void ImportList(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }
            StreamReader sr = new StreamReader(fileName, Encoding.UTF8);
            string list = sr.ReadToEnd();
            sr.Close();
            ListToItems(list);
        }

        private void ListToItems(string list)
        {
            OfficeList.Items.Clear();
            string[] arr = list.Split(';');
            Array.Reverse(arr);
            foreach (string item in arr)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    OfficeList.Items.Insert(0, item);
                }
            }
            OfficeList.SelectedIndex = 0;
        }

        /// <summary>
        /// 导出单位列表
        /// </summary>
        private void ExportButton_Click(object sender, EventArgs e)
        {
            ListSaveDialog.ShowDialog();
            string fileName = ListSaveDialog.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }
            ExportList(fileName);
            MessageBox.Show($"已导出到：{fileName}");
        }

        private void ExportList(string fullPath)
        {
            string list = ItemsToList();
            StreamWriter sw = new StreamWriter(fullPath, false, Encoding.UTF8);
            sw.Write(list);
            sw.Close();
        }

        private string ItemsToList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object item in OfficeList.Items)
            {
                sb.Append(item.ToString() + ";");
            }
            string list = sb.ToString();
            return list;
        }

        private void SolidRadio_Click(object sender, EventArgs e)
        {
            SolidRadio.Checked = true;
            SetGroupEnable();
        }

        private void NumberRadio_Click(object sender, EventArgs e)
        {
            NumberRadio.Checked = true;
            SetGroupEnable();
        }

        private void ListRadio_Click(object sender, EventArgs e)
        {
            ListRadio.Checked = true;
            SetGroupEnable();
        }

        /// <summary>
        /// 开始执行
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                ShowLog("验证通过");
                MarkKind kind = GetMarkKind();
                string source = SourceText.Text;
                string target = TargetText.Text;
                List<string> textList = new List<string>();
                int begin = Convert.ToInt32(StartNumeric.Value);
                int end = Convert.ToInt32(EndNumeric.Value);

                foreach (object item in OfficeList.Items)
                {
                    textList.Add(item.ToString());
                }
                Mark markDemo = new Mark
                {
                    Color = MarkColorPicture.BackColor,
                    Font = MarkFontText.Text,
                    Rotation = Convert.ToInt32(MarkRotationNumeric.Value),
                    Size = Convert.ToInt32(MarkSizeNumeric.Value),
                };
                MarkList markList = null;
                switch (kind)
                {
                    case MarkKind.solid:
                        markList = new MarkList(markDemo, SolidText.Text);
                        break;
                    case MarkKind.list:
                        markList = new MarkList(markDemo, textList);
                        break;
                    case MarkKind.number:
                        markList = new MarkList(markDemo, begin, end);
                        break;
                }
                MarkFactory fact = new MarkFactory(markList.GetMarks(), source, target);
                ShowLog("开始生成水印，请勿关闭...");
                DateTime stime = DateTime.Now;
                int count = fact.Generate();
                double timeCost = (DateTime.Now - stime).TotalMilliseconds;
                ShowLog($"已完成！({timeCost}ms)");
                ShowLog($"生成了{count}个水印文件");
            }
        }

        private MarkKind GetMarkKind()
        {
            MarkKind kind = MarkKind.err;
            if (SolidRadio.Checked)
            {
                kind = MarkKind.solid;
                ShowLog("启动固定文本模式");
            }
            if (NumberRadio.Checked)
            {
                kind = MarkKind.number;
                ShowLog("启动数字序号模式");
            }
            if (ListRadio.Checked)
            {
                kind = MarkKind.list;
                ShowLog("启动单位列表模式");
            }
            return kind;
        }

        private bool IsValidated()
        {
            ErrorProvider.Clear();
            //
            // 源文件 & 输出文件夹
            //
            if (string.IsNullOrEmpty(SourceText.Text.Trim()))
            {
                ErrorProvider.SetError(SourceText, "请选择源文件");
                return false;
            }
            if (string.IsNullOrEmpty(TargetText.Text.Trim()))
            {
                ErrorProvider.SetError(TargetText, "请选择输出文件夹");
                return false;
            }
            //
            // 水印种类 单选框组
            //
            bool radioChecked =
                SolidRadio.Checked
                || ListRadio.Checked
                || NumberRadio.Checked;
            if (!radioChecked)
            {
                ErrorProvider.SetError(MarkKindGroup, "请至少选择一项");
                return false;
            }
            //
            // 字体
            //
            if (string.IsNullOrEmpty(MarkFontText.Text.Trim()))
            {
                ErrorProvider.SetError(MarkFontText, "请设置水印字体");
                return false;
            }
            //
            // 固定文本水印框
            //
            if (SolidRadio.Checked && string.IsNullOrEmpty(SolidText.Text.Trim()))
            {
                ErrorProvider.SetError(SolidText, "请输入水印文字");
                return false;
            }
            //
            // 数字序号开始数字，结束数字
            //
            if (EndNumeric.Value < StartNumeric.Value)
            {
                ErrorProvider.SetError(EndNumeric, "结束序号应大于等于开始序号");
                return false;
            }
            //
            // 单位名称列表
            //
            if (ListRadio.Checked)
            {
                if (OfficeList.Items.Count == 0)
                {
                    ErrorProvider.SetError(OfficeList, "请至少添加一个单位");
                    return false;
                }
            }
            return true;
        }
        private void ShowLog(string message)
        {
            LoggerList.Items.Insert(0, message);
            LoggerList.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OnPrinting)
            {
                e.Cancel = true;
                return;
            }
            if (MessageBox.Show("确定退出？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!SaveSettingsToIniFile(out string err))
                {
                    if (MessageBox.Show($"保存配置失败,继续退出？\n{err}", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private bool SaveSettingsToIniFile(out string ErrMessage)
        {
            ErrMessage = "";

            try
            {
                string list = ItemsToList();
                INI_Helper.WriteIni("AutoSave", "SOLID_CHECK", SolidRadio.Checked.ToString(), settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "NUMBER_CHECK", NumberRadio.Checked.ToString(), settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "LIST_CHECK", ListRadio.Checked.ToString(), settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "COLOR", MarkColorPicture.BackColor.ToArgb().ToString(), settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "ROTATION", MarkRotationNumeric.Value.ToString(), settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "FONT", MarkFontText.Text, settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "SOLID_TEXT", SolidText.Text, settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "BEGIN", StartNumeric.Value.ToString(), settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "END", EndNumeric.Value.ToString(), settingsFilePath);
                INI_Helper.WriteIni("AutoSave", "LIST", list, settingsFilePath);
                return true;
            }
            catch (Exception ex)
            {
                ErrMessage = $"{ex.Source}发生错误:{ex.Message}";
                return false;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // load settings
            if (File.Exists(settingsFilePath))
            {
                if (!LoadSettingsFromIniFile(out string err))
                {
                    File.Delete(settingsFilePath);
                    MessageBox.Show($"读取配置失败,已将配置文件重置.\n{err}", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // set enables
            SetGroupEnable();
        }

        private void SetGroupEnable()
        {
            SolidGroup.Enabled = SolidRadio.Checked;
            foreach (Control control in SolidGroup.Controls)
            {
                control.Enabled = SolidRadio.Checked;
            }
            NumberGroup.Enabled = NumberRadio.Checked;
            foreach (Control control in NumberGroup.Controls)
            {
                control.Enabled = NumberRadio.Checked;
            }
            OfficeGroup.Enabled = ListRadio.Checked;
            foreach (Control control in OfficeGroup.Controls)
            {
                control.Enabled = ListRadio.Checked;
            }
        }

        private bool LoadSettingsFromIniFile(out string ErrMessage)
        {
            ErrMessage = "";

            try
            {
                SolidRadio.Checked = Convert.ToBoolean(INI_Helper.ReadIni("AutoSave", "SOLID_CHECK", settingsFilePath));
                NumberRadio.Checked = Convert.ToBoolean(INI_Helper.ReadIni("AutoSave", "NUMBER_CHECK", settingsFilePath));
                ListRadio.Checked = Convert.ToBoolean(INI_Helper.ReadIni("AutoSave", "LIST_CHECK", settingsFilePath));
                MarkColorPicture.BackColor = Color.FromArgb(Convert.ToInt32(INI_Helper.ReadIni("AutoSave", "COLOR", settingsFilePath)));
                MarkRotationNumeric.Value = Convert.ToDecimal(INI_Helper.ReadIni("AutoSave", "ROTATION", settingsFilePath));
                MarkFontText.Text = INI_Helper.ReadIni("AutoSave", "FONT", settingsFilePath);
                SolidText.Text = INI_Helper.ReadIni("AutoSave", "SOLID_TEXT", settingsFilePath);
                StartNumeric.Value = Convert.ToDecimal(INI_Helper.ReadIni("AutoSave", "BEGIN", settingsFilePath));
                EndNumeric.Value = Convert.ToDecimal(INI_Helper.ReadIni("AutoSave", "END", settingsFilePath));
                ListToItems(INI_Helper.ReadIni("AutoSave", "LIST", settingsFilePath));
                return true;
            }
            catch (Exception ex)
            {
                ErrMessage = $"{ex.Source}发生错误:{ex.Message}";
                return false;
            }
        }

        private async void PrintButton_Click(object sender, EventArgs e)
        {
            string folderForPrint;
            if (Directory.Exists(TargetText.Text))
            {
                folderForPrint = TargetText.Text;
            }
            else
            {
                if (PrintFolderDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                folderForPrint = PrintFolderDialog.SelectedPath;
            }
            if (PrintDialog.ShowDialog() == DialogResult.OK)
            {
                PrinterSettings settings = PrintDialog.PrinterSettings;
                MarkPrinter printer = new MarkPrinter(folderForPrint, settings);
                var progress = new Progress<ProgressPartialResult>();
                progress.ProgressChanged += new EventHandler<ProgressPartialResult>(progress_ProgressChanged);
                ShowLog("[开始]与打印机通信中,请勿关闭程序!");
                PrintButton.Enabled = false;
                OnPrinting = true;
                bool printResult = await printer.PrintAsync(progress);
                ShowLog("[完成]全部文件已传送到打印机!");
                PrintButton.Enabled = true;
                OnPrinting = false;
                if (!printResult)
                {
                    MessageBox.Show("空文件夹");
                }
            }
        }

        private void progress_ProgressChanged(object sender, ProgressPartialResult e)
        {
            ShowLog($"正在将文件传送到打印机:{e.Current}/{e.Total}");
        }
    }
}

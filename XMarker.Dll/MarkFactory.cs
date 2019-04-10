using Aspose.Words;
using Aspose.Words.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace XMarker.DLL
{
    public class MarkFactory
    {
        public List<Mark> Marks { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public MarkFactory(List<Mark> marks, string source, string target)
        {
            Marks = marks ?? throw new ArgumentNullException(nameof(marks));
            Source = source ?? throw new ArgumentNullException(nameof(source));
            Target = target ?? throw new ArgumentNullException(nameof(target));
        }
        public int Generate()
        {
            if (Marks.Count == 0 &&
                !File.Exists(Source) &&
                !Directory.Exists(Target))
            {
                return 0;
            }

            foreach (var mark in Marks)
            {
                if (!CreateMarkedFile(mark, Source, Target))
                {
                    var sourceName = Path.GetFileNameWithoutExtension(Source);
                    throw new Exception($"创建水印文件：\n{sourceName}_{mark.Text}\n到\n{Target}\n失败。");
                }
            }
            return Marks.Count();
        }

        private bool CreateMarkedFile(Mark mark, string source, string target)
        {
            var sourceName = Path.GetFileNameWithoutExtension(source);
            var targetName = $"({mark.Text}){sourceName}";
            var sourceEx = Path.GetExtension(source);
            var targertFullPath = target + "\\" + targetName + sourceEx;

            Document doc = new Document(source);

            if (!InsertMarker(doc, mark))
            {
                return false;
            }
            doc.Save(targertFullPath);
            return true;
        }

        private bool InsertMarker(Document doc, Mark mark)
        {
            try
            {
                Shape shape = new Shape(doc, ShapeType.TextPlainText);

                shape.TextPath.Text = mark.Text;
                shape.TextPath.FontFamily = mark.Font;
                shape.Height = mark.Size;
                switch (mark.Kind)
                {
                    case MarkTextKind.Han:
                        shape.Width = mark.Text.Length * mark.Size;
                        break;
                    case MarkTextKind.Letter:
                    case MarkTextKind.Numberic:
                        shape.Width = mark.Text.Length * mark.Size / 2;
                        break;
                    default:
                        throw new Exception($"不存在的水印文本类型：\n{mark.Kind.ToString()}");
                }
                shape.Width = mark.Text.Length * mark.Size;
                shape.Rotation = mark.Rotation;
                shape.Fill.Color = mark.Color;
                shape.StrokeColor = mark.Color;

                shape.RelativeHorizontalPosition = RelativeHorizontalPosition.Page;
                shape.RelativeVerticalPosition = RelativeVerticalPosition.Page;
                shape.WrapType = WrapType.None;
                shape.VerticalAlignment = VerticalAlignment.Center;
                shape.HorizontalAlignment = HorizontalAlignment.Center;

                Paragraph para = new Paragraph(doc);
                para.AppendChild(shape);

                foreach (Section section in doc.Sections)
                {
                    InsertToHeader(para, section, HeaderFooterType.HeaderPrimary);
                    InsertToHeader(para, section, HeaderFooterType.HeaderFirst);
                    InsertToHeader(para, section, HeaderFooterType.HeaderEven);
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private void InsertToHeader(Paragraph para, Section section, HeaderFooterType headerType)
        {
            HeaderFooter header = section.HeadersFooters[headerType];

            if (header == null)
            {
                header = new HeaderFooter(section.Document, headerType);
                section.HeadersFooters.Add(header);
            }

            header.AppendChild(para.Clone(true));
        }
    }
}

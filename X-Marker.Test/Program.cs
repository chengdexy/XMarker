using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMarker.DLL;
using System.Drawing;
using XMarker.Dll;
using X_Marker.Dll;

namespace XMarker.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Users\Chengdexy\Desktop\123.docx =>
            // C:\Users\Chengdexy\Desktop\123_Hello.docx
            var source = @"C:\Users\Chengdexy\Desktop\123.docx";
            var target = @"C:\Users\Chengdexy\Desktop";
            var color = Color.LightGray;
            var font = "微软雅黑";
            var kind = MarkTextKind.Numberic;
            var rotation = -40;
            var size = 80;
            var begin = 1;
            var end = 3;
            var markKind = MarkKind.number;
            Mark demo = new Mark
            {
                Color = color,
                Font = font,
                Kind = kind,
                Rotation = rotation,
                Size = size
            };
            Config cfg = new Config
            {
                MarkDemo = demo,
                Begin = begin,
                End = end,
                MarkKind = markKind
            };
            int count = MarkIt(source, target, demo, cfg);
            Console.WriteLine($"影响 {count} 条。");
            Console.ReadKey();
        }

        private static int MarkIt(string source, string target, Mark demo, Config cfg)
        {
            MarkList list;
            switch (cfg.MarkKind)
            {
                case MarkKind.solid:
                    list = new MarkList(demo, cfg.SolidText);
                    break;
                case MarkKind.list:
                    list = new MarkList(demo, cfg.TextList);
                    break;
                case MarkKind.number:
                    list = new MarkList(demo, cfg.Begin, cfg.End);
                    break;
                default:
                    throw new Exception($"{cfg.MarkKind.ToString()} is not exist.");
            }

            MarkFactory factory = new MarkFactory(list.GetMarks(), source, target);
            var count = factory.Generate();
            return count;
        }
    }
}

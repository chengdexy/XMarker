using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMarker.DLL;

namespace X_Marker.Dll
{
    public class MarkList
    {
        private readonly List<Mark> marks;
        private readonly Mark _markDemo;
        public MarkList(Mark markDemo)
        {
            _markDemo = markDemo;
        }
        public MarkList(Mark markDemo, string text) : this(markDemo)
        {
            marks = new List<Mark> { new Mark
            {
                Color=_markDemo.Color,
                Font=_markDemo.Font,
                Kind=_markDemo.Kind,
                Rotation=_markDemo.Rotation,
                Size=_markDemo.Size,
                Text=text
            } };
        }
        public MarkList(Mark markDemo, int begin, int end) : this(markDemo)
        {
            marks = new List<Mark>();
            for (int i = begin; i < end + 1; i++)
            {
                marks.Add(new Mark
                {
                    Color = _markDemo.Color,
                    Font = _markDemo.Font,
                    Kind = _markDemo.Kind,
                    Rotation = _markDemo.Rotation,
                    Size = _markDemo.Size,
                    Text = i.ToString("000")
                });
            }
        }
        public MarkList(Mark markDemo, List<string> list) : this(markDemo)
        {
            marks = new List<Mark>();
            foreach (var text in list)
            {
                marks.Add(new Mark
                {
                    Color = _markDemo.Color,
                    Font = _markDemo.Font,
                    Kind = _markDemo.Kind,
                    Rotation = _markDemo.Rotation,
                    Size = _markDemo.Size,
                    Text = text
                });
            }
        }
        public List<Mark> GetMarks()
        {
            if (marks == null)
            {
                throw new Exception($"水印列表为空。");
            }

            return marks;
        }
    }
}

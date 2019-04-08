using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMarker.DLL;

namespace X_Marker.Dll
{
    public class Config
    {
        public Mark MarkDemo { get; set; }
        public string SolidText { get; set; }
        public int Begin { get; set; }
        public int End { get; set; }
        public List<string> TextList { get; set; }
        public MarkKind MarkKind { get; set; }
    }
    public enum MarkKind
    {
        solid,
        list,
        number
    }
}

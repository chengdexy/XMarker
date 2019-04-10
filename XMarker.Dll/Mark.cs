using System.Drawing;

namespace XMarker.DLL
{
    public class Mark
    {
        public string Text { get; set; }
        public Color Color { get; set; }
        public string Font { get; set; }
        public int Size { get; set; }
        public int Rotation { get; set; }
        public MarkTextKind Kind { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

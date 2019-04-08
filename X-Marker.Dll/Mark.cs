using System.Drawing;

namespace XMarker.DLL
{
    /// <summary>
    /// 水印基类：用于描述水印的特征
    /// </summary>
    public class Mark
    {
        /// <summary>
        /// 水印文字
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 水印颜色
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// 水印字体
        /// </summary>
        public string Font { get; set; }
        /// <summary>
        /// 水印大小
        ///     值指示水印字符的高度
        ///     汉字水印宽度为 值×字数
        ///     英文或数字宽度为 值×字数÷2
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// 水印倾斜角度
        ///     0 为无倾斜
        ///     适用范围为 -90 ~ 90
        /// </summary>
        public int Rotation { get; set; }
        public MarkTextKind Kind { get; set; }

        public override string ToString() => Text;
    }

    public enum MarkTextKind
    {
        Han,
        Numberic,
        Letter
    }
}

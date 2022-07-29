using TelCo.ColorCoder.Enums;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// data type defined to hold the two colors of color pair
    /// </summary>
    public class ColorPair
    {
        public MajorColor MajorColor { get; private set; }
        public MinorColor MinorColor { get; private set; }

        public ColorPair(MajorColor majorColor, MinorColor minorColor)
        {
            MajorColor = majorColor;
            MinorColor = minorColor;
        }

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.ToString(), MinorColor.ToString());
        }
    }
}

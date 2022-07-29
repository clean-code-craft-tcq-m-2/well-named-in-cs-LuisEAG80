using System;

using TelCo.ColorCoder.Enums;

namespace TelCo.ColorCoder
{
    public class PairColorCode
    {
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            var minorSize = Enum.GetNames(typeof(MinorColor)).Length;
            var majorSize = Enum.GetNames(typeof(MajorColor)).Length;

            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            int majorIndex = (pairNumber - 1) / minorSize;
            int minorIndex = (pairNumber - 1) % minorSize;

            // Construct the return val from the arrays
            ColorPair pair = new ColorPair(
                majorColor: (MajorColor)majorIndex,
                minorColor: (MinorColor)minorIndex
            );

            // return the value
            return pair;
        }

        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            var minorSize = Enum.GetNames(typeof(MinorColor)).Length;

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return ((int)(pair.MajorColor) * minorSize) + ((int)(pair.MinorColor)) + 1;
        }
    }
}

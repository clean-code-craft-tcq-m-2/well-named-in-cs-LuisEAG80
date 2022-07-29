using System;
using System.Diagnostics;

using TelCo.ColorCoder.Enums;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair testPair1 = PairColorCode.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == MajorColor.White);
            Debug.Assert(testPair1.MinorColor == MinorColor.Brown);

            pairNumber = 5;
            testPair1 = PairColorCode.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == MajorColor.White);
            Debug.Assert(testPair1.MinorColor == MinorColor.SlateGray);

            pairNumber = 23;
            testPair1 = PairColorCode.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor == MajorColor.Violet);
            Debug.Assert(testPair1.MinorColor == MinorColor.Green);

            ColorPair testPair2 = new ColorPair(MajorColor.Yellow, MinorColor.Green);
            pairNumber = PairColorCode.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair(MajorColor.Red, MinorColor.Blue);
            pairNumber = PairColorCode.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDOLChecker
{
    public class RefData
    {
        public static Dictionary<int, int> WeightingFactors;
        public static Dictionary<string, int> LetterValues;
        public static void Initialize()
        {
            WeightingFactors = GetWeightingFactor();
            LetterValues = GetLetterValues();
        }


        private static Dictionary<int, int> GetWeightingFactor()
        {
            //First:  1; Second: 3; Third: 1; Fourth: 7; Fifth: 3; Sixth: 9;
            Dictionary<int, int> weightingFactors = new Dictionary<int, int>();
            weightingFactors.Add(1, 1);
            weightingFactors.Add(2, 3);
            weightingFactors.Add(3, 1);
            weightingFactors.Add(4, 7);
            weightingFactors.Add(5, 3);
            weightingFactors.Add(6, 9);
            return weightingFactors;
        }
        private static Dictionary<string, int> GetLetterValues()
        {
            Dictionary<string, int> letterValues = new Dictionary<string, int>();
            letterValues.Add("a", 10);
            letterValues.Add("b", 11);
            letterValues.Add("c", 12);
            letterValues.Add("d", 13);
            letterValues.Add("e", 14);
            letterValues.Add("f", 15);
            letterValues.Add("g", 16);
            letterValues.Add("h", 17);
            letterValues.Add("i", 18);
            letterValues.Add("j", 19);
            letterValues.Add("k", 20);
            letterValues.Add("l", 21);
            letterValues.Add("m", 22);
            letterValues.Add("n", 23);
            letterValues.Add("o", 24);
            letterValues.Add("p", 25);
            letterValues.Add("q", 26);
            letterValues.Add("r", 27);
            letterValues.Add("s", 28);
            letterValues.Add("t", 29);
            letterValues.Add("u", 30);
            letterValues.Add("v", 31);
            letterValues.Add("w", 32);
            letterValues.Add("x", 32);
            letterValues.Add("y", 34);
            letterValues.Add("z", 35);
            return letterValues;
        }
    }
}

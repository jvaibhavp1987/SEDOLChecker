using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SEDOLChecker
{
    public class ExtensionHelper
    {
        public static int ParseToInt(string inputValue)
        {
            int result = -1;
            int.TryParse(inputValue, out result);
            return result;
        }

        public static bool IsSpecialCharPresent(string inputValue)
        {
            char[] one = inputValue.ToCharArray();
            return (inputValue.Any(c => !Char.IsLetterOrDigit(c)));
        }
    }
}

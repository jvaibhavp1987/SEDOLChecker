using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SEDOLChecker
{
    public class FilterHelper
    {
        public static bool IsValidInput(string input, out string ErrorMessage )
        {
            const int SECURITYIDENTIFIER_LENGTH = 7;
            ErrorMessage = "";

            if (string.IsNullOrWhiteSpace(input) || input?.Length != SECURITYIDENTIFIER_LENGTH)
            {
                ErrorMessage = "Input string was not 7-characters long";
                return false;
            }

            if (ExtensionHelper.IsSpecialCharPresent(input))
            {
                ErrorMessage = "SEDOL contains invalid characters";
                return false;
            }
            return true;
        }
    }
}

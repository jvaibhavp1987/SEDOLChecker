using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SEDOLChecker
{
    public interface ISedolValidator
    {
        ISedolValidationResult ValidateSedol(string input);
    }

    public class SedolValidator : ISedolValidator
    {
        const int SECURITYCODE_LENGTH = 6;

        public ISedolValidationResult ValidateSedol(string input)
        {
            
            bool isValidSedol = false;
            var isUserDefined = false;
            string validationError = string.Empty;
            RefData.Initialize();
            var isValid = FilterHelper.IsValidInput(input, out validationError);
            if (isValid)
            {
                var InputCheckSum = ExtensionHelper.ParseToInt(input.Substring(6, 1));
                var CalculatedcheckSum = CalculateWeightedSum(input);
                isValidSedol = (InputCheckSum == CalculatedcheckSum ? true : false);

                if (!isValidSedol)
                {
                    validationError = "Checksum digit does not agree with the rest of the input";
                }
                isUserDefined = input.StartsWith("9") ? true : false;
            }

            return new SedolValidationResult
            {
                InputString = input,
                IsValidSedol = isValidSedol,
                IsUserDefined = isUserDefined,
                ValidationDetails = validationError
            };
        }

        /// <summary>
        /// Function to Calcuate the Weighted Sum
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int CalculateWeightedSum(string input)
        {
            Dictionary<int, int> weightingFactors = RefData.WeightingFactors;
            Dictionary<string, int> letterValues = RefData.LetterValues;

            Char[] _InputChar = input.ToCharArray();
            int weightedSum = 0;
            for (int i = 0; i < SECURITYCODE_LENGTH; i++)
            {
                var inputField = _InputChar[i].ToString()?.ToLower();
                if (inputField.Any(Char.IsLetter))
                {
                    var result = letterValues[inputField] * weightingFactors[i + 1];
                    weightedSum = weightedSum + result;
                }
                else
                {
                    int parseInputValue = -1;
                    int.TryParse(inputField, out parseInputValue);
                    var result = parseInputValue * weightingFactors[i + 1];
                    weightedSum = weightedSum + result;
                }
            }
            var CalculatedcheckSum = (10 - (weightedSum % 10)) % 10;
            return CalculatedcheckSum;
        }
    }
}

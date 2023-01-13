using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDOLChecker
{
    public interface ISedolValidationResult
    {
        string InputString { get; }
        bool IsValidSedol { get; }
        bool IsUserDefined { get; }
        string ValidationDetails { get; }
    }
    public class SedolValidationResult : ISedolValidationResult
    {
        public string InputString { get; set; }
        public bool IsValidSedol { get; set; }
        public bool IsUserDefined { get; set; }
        public string ValidationDetails { get; set; }

        public override string ToString()
        {
            return $"{InputString}|{IsValidSedol}|{IsUserDefined}|{ValidationDetails}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDOLChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SedolValidator sedolValidator = new SedolValidator();
            sedolValidator.ValidateSedol("0709954");

            //-----------Test Cases
            //var result = sedolValidator.ValidateSedol("1234567");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("0709954");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("B0YBKJ7");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("9123451");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("9ABCDE8");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("9123_51");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("VA.CDE8");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("9123458");
            //Console.WriteLine(result.ToString());
            //result = sedolValidator.ValidateSedol("9ABCDE1");
            //Console.WriteLine(result.ToString());
            //Console.ReadLine();

        }
    }
}

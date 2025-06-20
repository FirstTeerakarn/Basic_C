using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Score;
            string result;

            Console.Write("Input Score : ");
            int.TryParse(Console.ReadLine(), out Score);

            result = (Score >= 50) ? "Pass" : "Not Pass";

            Console.Write("Status : {0}", result);
            Console.ReadKey();
        }
    }
}

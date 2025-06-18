using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int score;
            Console.WriteLine("Input Score :");
            int.TryParse(Console.ReadLine(), out score);

            //Process & Output
            if (score >= 80)
            {
                Console.WriteLine("Grade A");
            }else if (score >=70)
            {
                Console.WriteLine("Grade B");
            }else if (score >= 60)
            {
                Console.WriteLine("Grade C");
            }else if (score >= 50)
            {
                Console.WriteLine("Grade D");
            }else
            {
                Console.WriteLine("Grade F");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int score;
            string grade;
            Console.Write("Input Score : ");
            int.TryParse(Console.ReadLine(), out score);

            if (score >= 80 && score <= 100)
            {
                grade = "A";
            }
            else if (score <= 79 && score >= 70)
            {
                grade = "B";
            }
            else if (score <= 69 && score >= 60)
            {
                grade = "C";
            }
            else if (score <= 59 && score >= 50)
            {
                grade = "D";
            }
            else if (score >= 0 && score <= 50)
            {
                grade = "F";
            }
            else
            {
                grade = "No Data";
            }

            Console.WriteLine("Score = {0} , Grade = {1}", score, grade);
            Console.ReadKey();
        }
    }
}

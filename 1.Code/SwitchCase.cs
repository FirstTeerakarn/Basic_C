using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, choice;
            int result;

            Console.Write("Input Number1 = ");
            int.TryParse(Console.ReadLine(), out number1);

            Console.Write("Input Number2 = ");
            int.TryParse(Console.ReadLine(), out number2);

            Console.Write("Input Choice |1=(+), 2=(-)| = ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice) 
            {
                case 1: 
                    result = number1 + number2;
                    Console.WriteLine(result);
                    break;

                case 2: 
                    result = number1 - number2;
                    Console.WriteLine(result);
                    break;

                default: Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();
        }
    }
}

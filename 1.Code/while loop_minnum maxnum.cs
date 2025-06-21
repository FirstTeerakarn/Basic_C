using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //แก้ปัญหาโดยใช้ while Loop

            int minnumber = int.MaxValue; //int.MaxValue == 2147483647
            int maxnumber = 0;

            while (true)
            {
                int number;
                Console.Write("Inpuit Number : ");
                int.TryParse(Console.ReadLine(), out number);
                if (number < 0) break;

                if (number > maxnumber)
                {
                    maxnumber = number;
                }
                // ( 50 < 2147483647 ) -> ค่าสูงสุดของ int
                if (number < minnumber)
                {
                    minnumber = number;
                }
            }
            Console.WriteLine("Max Number = {0}", maxnumber);
            Console.WriteLine("Min Number = {0}", minnumber);
            Console.ReadKey();
        }
    }
}

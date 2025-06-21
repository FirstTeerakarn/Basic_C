using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_sum_and_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, avg = 0;
            int count = 0;
            //for (int count = 1; count <= 5; count++) //1

            while (true)
            {
                int number;
                Console.Write("Inpuit Number : ");
                int.TryParse(Console.ReadLine(), out number);
                if (number < 0) break; //ค่าที่ส่่งเข้ามาเป็น - ให้ออกจาก loop
                count++;
                sum += number;
            }

            Console.WriteLine("Summation = {0}", sum);
            // avg = sum / 5; //1
            avg = sum / count;
            Console.WriteLine("Averrage = {0}", avg);
            Console.ReadKey();
        }
    }
}
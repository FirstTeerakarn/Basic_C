using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Input Number : ");
            int.TryParse(Console.ReadLine(), out number);

            //While Loop
            /*int count = 1;
            while (count <= 12)
            {
                //คำสั่งที่ต้องการให้ทำซ้ำ
                Console.WriteLine("{0} x {1} = {2}", number, count, number*count);
                count++;
            }
            */


            //For Loop
            for (int count = 1; count <= 12; count++)
            {
                //คำสั่งที่ต้องการให้ทำซ้ำ
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count);
            }

            Console.ReadKey();
        }
    }
}

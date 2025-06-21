using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //การใช้ break และ continue ใน for loop
            int number;
            Console.Write("Enter Number : ");
            int.TryParse(Console.ReadLine(), out number);

            for (int count = 1; count <= 12; count++)
            {
                if(count  == 5)
                {
                    //break; // ถึงรอบที่ 5 เมื่อไหร่ให้ออกจาก loop ทันที
                    continue; //เมื่อ count มีค่า =5 กระโดดข้าม 5 ไปทำloopถัดไป
                }
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count);
            }
            Console.WriteLine("End Program");
            Console.ReadKey();
        }
    }
}

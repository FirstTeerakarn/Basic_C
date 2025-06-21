using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 100 - 20,000  Baht
            int money;
            do
            {
                Console.Write("Input Money = ");
                int.TryParse(Console.ReadLine(), out money); //ทดสอบกรอก 1800
            }
            while ((money % 100 != 0) || (money >= 20000));
            //เช็คจำนวนเงินว่าเป็นหลักหน่วยหรือหลักสิบให้กลับไปทำ do ใหม่ || มากกว่า 20000 หรือป่าวถ้าเกินกลับไปทำ do ใหม่

            Console.WriteLine("Money = {0}", money); //1800

            Console.WriteLine("1000 Baht = {0}", money / 1000); //1 ใบ
            money = money % 1000; // 1800/1000 = เศษ 800

            Console.WriteLine("500 Baht = {0}", money / 500); //1 ใบ
            money = money % 500; // 1800/1000 = เศษ 300

            Console.WriteLine("100 Baht = {0}", money / 100); //3 ใบ

            Console.ReadKey();
        }
    }
}

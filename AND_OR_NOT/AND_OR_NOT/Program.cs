using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND_OR_NOT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter gender (male/female) : ");
            string gender = Console.ReadLine();

            Console.Write("Enter height : ");
            int height = int.Parse(Console.ReadLine());

            //Process & Output
            //AND และ
            if (gender == "male" && height >= 160)
            {
                Console.WriteLine("Pass");
            }else
            {
                Console.WriteLine("Not Pass");
            }


            /* //OR หรือ
            if (gender == "male" || height >= 160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }
            */


            /* //NOT ตรงกันข้าม
            if (!(height >= 160)) //true => false
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }
            */

            Console.ReadKey();
        }
    }
}

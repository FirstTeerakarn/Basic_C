using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Dog";

            if (name == "First")
            {   //คำสั่งต่างๆ
                Console.WriteLine("Hello : Teerakarn");
            }

            else
            {   //คำสั่งต่างๆ
                Console.WriteLine("Hello User : {0}", name);
            }
            Console.WriteLine("End Program");
            Console.ReadKey();
        }
    }
}

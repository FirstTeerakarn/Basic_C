using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            //Input
            Console.Write("Input Weight (kg):");
            double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Input Height (cm):");
            double.TryParse(Console.ReadLine(), out height);

            //Process
            //BMI = wweight / height^2
            height = height / 100;
            double bmi = weight / Math.Pow(height, 2); //Math.Pow = ค่า height^2

            //Output
            Console.WriteLine("BMI = {0:F2}", bmi); //Format String :F2 แสดงทศนิยม 2 ตำแหน่ง
            Console.ReadKey();
        }
    }
}

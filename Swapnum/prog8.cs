using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnum
{
    internal class prog8
    {
        static void Main(string[] args)
        {
            double celsius, kelvin, fahrenheit;

            Console.WriteLine("enter the amount of Celsius:");
            celsius=Convert.ToDouble(Console.ReadLine());

            kelvin = celsius + 273.15;
            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin ={kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
            Console.ReadLine();
        }
    }
}

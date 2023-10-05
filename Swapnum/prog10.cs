using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnum
{
    internal class prog10
    {
        static void Main(string[] args)
        {
            int n1, n2,absdiff=0;
            Console.WriteLine("\n Enter the First Absolute Number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the Second Absolute Number :");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1>n2) 
            {
                absdiff=(n1-n2)*2;
                Console.WriteLine($"{n1} is greater than {n2}");
                Console.WriteLine($"The Absolute Difference is {absdiff}");
            }
            else
            {
                absdiff = n2 - n1;
                Console.WriteLine($"The Absolute Difference is {absdiff}");
            }    
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnum
{
    internal class prog9
    {
        static void Main(string[] args)
        {
            int n1, n2, sum=0;
            Console.WriteLine("\n Enter the First Number :");
             n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the Second Number :");
             n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2) 
            { 
                sum=(n1+n2)*3;
                Console.WriteLine("Both are Equal");
                Console.WriteLine($"The triple of their sum is:{sum}");
            }
            else
            {
                sum=n1+n2;
                Console.WriteLine("Both are not Equal");
                Console.WriteLine($"The sum is: {sum}");
            }
            Console.ReadLine();
        }
    }   
}


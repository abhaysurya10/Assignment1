using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnum
{
    internal class prog6
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("\n Enter the First Number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the Second Number :");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1<n2)
            {
                Console.WriteLine($"Maximum number:{n2}");
                Console.WriteLine($"Minimum number:{n1}");
            }
            else if(n2<n1){
                Console.WriteLine($"Maximum number:{n1}");
                Console.WriteLine($"Minimum number:{n2}");
            }
            else
            {
                Console.WriteLine($"Both Numbers are Equal:{n1}");
            }
            Console.ReadLine();
        }
    }
}

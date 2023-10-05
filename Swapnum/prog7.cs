using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnum
{
    internal class prog7
    {
        static void Main(string[] args)
        {
            int m1, m2, m3,total,avg;
            Console.WriteLine("Input the First Subject Marks:");
             m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Subject Marks:");
             m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Third Subject Marks:");
             m3 = Convert.ToInt32(Console.ReadLine());

            total=m1+ m2+m3;
            avg = total / 3;
            Console.WriteLine($"Total marks of three subjects:{total} ");

            if(avg<35)
            {
                Console.WriteLine("Grade: Fail");
            }
            else if(avg>35 && avg < 45)
            {
                Console.WriteLine("Grade: Thrid");
            }
            else if (avg > 45 && avg < 60)
            {
                Console.WriteLine("Grade: Second");
            }
            else 
            {
                Console.WriteLine("Grade: First");
            }
            Console.ReadLine();
        }
    }
}
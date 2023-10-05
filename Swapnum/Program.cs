using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Swapnum
{
    internal class Program
    {
        static void swapNos(int a, int b)
        {
            int temp = a;
            a = b; 
            b = temp;
            Console.WriteLine($"\n After Swapping \n First Number: {a}\n Second Number: {b}");
        }

        static void multiply(int n1, int n2, int n3) 
        {
            int Result= n1*n2*n3;
            Console.WriteLine($"{n1}*{n2}*{n3}= {Result}");
        }

        static void asmdm(int a, int b)
        {
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            int mod = a % b;
            Console.WriteLine($"{a}+{b}= {add}");
            Console.WriteLine($"{a}-{b}= {sub}");
            Console.WriteLine($"{a}*{b}= {mul}");
            Console.WriteLine($"{a}/{b}= {div}");
            Console.WriteLine($"{a}%{b}= {mod}");
        }

        static void threenum(int x, int y, int z)
        {
            int res1= (x + y)*z;
            int res2= x*y + y*z;
            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {res1} and x.y + y.z is {res2}");
        }



        static void Main(string[] args)
        {
            //swap
            //Console.WriteLine("\n Input the First Number :");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\n Input the Second Number :");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //swapNos(firstNumber, secondNumber);


            //multiply
            //Console.WriteLine("Input the First Number:");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Second Number:");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the Third Number:");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //multiply(n1, n2, n3);
            //Console.ReadLine();

            //add,sub,mul,div,mod
            //Console.WriteLine("\n Input the First Number :");
            //int fNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\n Input the Second Number :");
            //int sNum = Convert.ToInt32(Console.ReadLine());
            //asmdm(fNum, sNum);
            //Console.ReadLine();

            //threenum(4)
            //Console.WriteLine("Enter the First Number:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Third Number:");
            //int z = Convert.ToInt32(Console.ReadLine());
            //threenum(x, y, z);
            //Console.ReadLine();

            //5

        }
    }
}

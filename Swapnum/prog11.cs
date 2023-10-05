using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnum
{
    internal class prog11
    {
        static void Main(string[] args)
        {
            int ndays, year, week, days, daysinweek = 7;
            Console.WriteLine("Enter the number of days");
            ndays = Convert.ToInt32(Console.ReadLine());
            year = ndays / 365;
            week = (ndays % 365) / daysinweek;
            days = (ndays % 365) % daysinweek;
            Console.WriteLine($"{ndays} is equivalent to {year}years, {week}weeks and {days}days");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter year...");
            int year = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Month...");
            int month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Day...");
            int day = Int32.Parse(Console.ReadLine());

            DateTime dt = new DateTime(year, month, day);
            Console.WriteLine(dt.ToString("F",
                        CultureInfo.CreateSpecificCulture("en-US")));
            Console.ReadKey();
        }
    }
}

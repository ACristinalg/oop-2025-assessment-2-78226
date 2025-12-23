using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_78226.Models
{
    public static class ExamQuestion_4
    {
        public static void Run()
        {
            Console.WriteLine("*** Question 4A (Format with Leading Zeros)***");
            Console.WriteLine(FiveDigitInt(25));
            Console.WriteLine(FiveDigitInt(54892));
            Console.WriteLine(FiveDigitInt(3));

            Console.WriteLine("\n(***Question 4B (Format Price ***");
            Console.WriteLine(FormatPrice(2548.5m));
            Console.WriteLine(FormatPrice(88.9m));
            Console.WriteLine(FormatPrice(5000000.50m));
        }

        public static string FiveDigitInt(int number)
        {
            return number.ToString("D5");
        }

        public static string FormatPrice(decimal price)
        {
            return price.ToString("C2", new System.Globalization.CultureInfo("en-IE"));
        }
    }
}
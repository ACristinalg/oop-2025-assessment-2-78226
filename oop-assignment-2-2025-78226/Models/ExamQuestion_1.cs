using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace oop_assignment_2_2025_78226.Models
{
    public static class ExamQuestion_1
    {
        public static void Run()
        {
            Console.WriteLine("*** Question 1A (Regex) ***");
            Console.WriteLine($"0831234567: {ValidIrishMobile("0831234567")}");
            Console.WriteLine($"0859876543: {ValidIrishMobile("0859876543")}");
            Console.WriteLine($"0812345678: {ValidIrishMobile("0812345678")}");
            Console.WriteLine($"083 1234567: {ValidIrishMobile("083 1234567")}");

            Console.WriteLine("\n*** Question 1B (Refactoring)***");
            Console.WriteLine($"Gold: {GetDiscountPercentage("Gold")}%");
            Console.WriteLine($"Silver: {GetDiscountPercentage("Silver")}%");
        }

        public static bool ValidIrishMobile(string number)
        {
            string pattern = @"^08[3589]\d{7}$";
            return Regex.IsMatch(number, pattern);
        }

        public static int GetDiscountPercentage(string membershipLevel)
        {
            return membershipLevel switch
            {
                "Gold" => 20,
                "Silver" => 10,
                "Bronze" => 5,
                _ => 0
            };
        }
    }
}
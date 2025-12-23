using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_78226.Models
{
    public static class ExamQuestion_2
    {
        public static void Run()
        {
            Console.WriteLine("***Question 2A***");
            Console.WriteLine(Divide(10, 2));
            Console.WriteLine(Divide(10, 0));

            Console.WriteLine("\n***Question 2B ***");
            Console.WriteLine(ParseNumber("123"));
            Console.WriteLine(ParseNumber("abc"));

            Console.WriteLine("\n***Question 2C ***");
            Console.WriteLine(RegisterUser(25));
            Console.WriteLine(RegisterUser(15));
        }

        public static string Divide(int number1, int number2)
        {
            try
            {
                int result = number1 / number2;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by zero.";
            }
        }

        public static string ParseNumber(string input)
        {
            try
            {
                int number = int.Parse(input);
                return number.ToString();
            }
            catch (FormatException)
            {
                return "Invalid number entered.";
            }
        }

        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException("age", "Must be at least 18");
                }
                return "Registration successful.";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "User must be at least 18 to register.";
            }
        }
    }
}
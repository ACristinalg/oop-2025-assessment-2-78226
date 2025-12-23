using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_78226.Models
{
    public static class ExamQuestion_3
    {
        public static void Run()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 }),
                ("Monitor", new List<int>()) // Producto sin ratings
            };

            Console.WriteLine("***Question 3 - Product Ratings***");
            AnalyzeProducts(products);
        }

        public static void AnalyzeProducts(List<(string Name, List<int> Ratings)> products)
        {
            string topProduct = "";
            double topRating = 0;

            foreach (var product in products)
            {
                if (product.Ratings.Count == 0)
                {
                    Console.WriteLine($"{product.Name}: No ratings available");
                    continue;
                }

                double average = product.Ratings.Average();
                Console.WriteLine($"{product.Name}: Average Rating = {average:F1}");

                if (average > topRating)
                {
                    topRating = average;
                    topProduct = product.Name;
                }
            }

            if (!string.IsNullOrEmpty(topProduct))
            {
                Console.WriteLine($"\nThe top-rated product is {topProduct} with an average rating of {topRating:F1}");
            }
        }
    }
}
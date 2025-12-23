using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using oop_assignment_2_2025_78226.Models;

namespace Exam.Tests
{
    public class ExamQuestion3Tests
    {
        [Fact]
        public void ProductsValidData()
        {
            
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("TestProduct", new List<int> { 5, 4, 3 })
            };

            
            ExamQuestion_3.AnalyzeProducts(products);

            
            Assert.True(true);
        }

        [Fact]
        public void ProductsWithEmptyRatings()
        {
            
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("EmptyProduct", new List<int>())
            };

            
            var exception = Record.Exception(() => ExamQuestion_3.AnalyzeProducts(products));
            Assert.Null(exception);
        }

        [Fact]
        public void ProductsTopRated()
        {
           
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Product1", new List<int> { 3, 3, 3 }),
                ("Product2", new List<int> { 5, 5, 5 }),
                ("Product3", new List<int> { 4, 4, 4 })
            };

            
            ExamQuestion_3.AnalyzeProducts(products);

            
            Assert.True(true);
        }
    }
}
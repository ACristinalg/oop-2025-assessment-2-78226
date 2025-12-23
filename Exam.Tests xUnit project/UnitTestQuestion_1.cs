using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xunit;
using oop_assignment_2_2025_78226.Models;

namespace Exam.Tests
{
    public class ExamQuestion1Tests
    {
        [Theory]
        [InlineData("0831234567", true)]
        [InlineData("0859876543", true)]
        [InlineData("0891122334", true)]
        [InlineData("0812345678", false)]
        [InlineData("083 1234567", false)]
        [InlineData("08312345678", false)]
        public void ValidIrishMobile_VariousInputs_ReturnsExpected(string number, bool expected)
        {
            bool result = ExamQuestion_1.ValidIrishMobile(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Gold", 20)]
        [InlineData("Silver", 10)]
        [InlineData("Bronze", 5)]
        [InlineData("None", 0)]
        public void GetDiscountPercentage_VariousLevels_ReturnsExpected(string level, int expected)
        {
            int result = ExamQuestion_1.GetDiscountPercentage(level);
            Assert.Equal(expected, result);
        }
    }
}

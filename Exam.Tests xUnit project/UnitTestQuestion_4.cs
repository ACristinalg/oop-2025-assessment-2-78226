using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using oop_assignment_2_2025_78226.Models;

namespace Exam.Tests
{
    public class ExamQuestion4Tests
    {
        [Theory]
        [InlineData(42, "00042")]
        [InlineData(7, "00007")]
        [InlineData(12345, "12345")]
        [InlineData(0, "00000")]
        [InlineData(999, "00999")]
        public void FiveDigitIntVariousNumbers(int number, string expected)
        {
            string result = ExamQuestion_4.FiveDigitInt(number);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FormatPriceDecimals()
        {
            string result = ExamQuestion_4.FormatPrice(2940.5m);
            Assert.Equal("€2,940.50", result);
        }

        [Fact]
        public void FormatPriceRoundsToTwoDecimals()
        {
            string result = ExamQuestion_4.FormatPrice(99.9m);
            Assert.Equal("€99.90", result);
        }

        [Fact]
        public void FormatPriceThousands()
        {
            string result = ExamQuestion_4.FormatPrice(1000000.50m);
            Assert.Equal("€1,000,000.50", result);
        }
    }
}
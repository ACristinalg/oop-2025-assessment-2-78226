using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using oop_assignment_2_2025_78226.Models;

namespace Exam.Tests
{
    public class ExamQuestion2Tests
    {
        [Fact]
        public void DivdebyzeroErrorMessage()
        {
            string result = ExamQuestion_2.Divide(10, 0);
            Assert.Equal("Cannot divide by zero.", result);
        }

        [Fact]
        public void DivideValidNumberResult()
        {
            string result = ExamQuestion_2.Divide(10, 2);
            Assert.Equal("5", result);
        }

        [Fact]
        public void PNumberInvalidInputErrorMessage()
        {
            string result = ExamQuestion_2.ParseNumber("abc");
            Assert.Equal("Invalid number entered.", result);
        }

        [Fact]
        public void PNumberValidInput()
        {
            string result = ExamQuestion_2.ParseNumber("123");
            Assert.Equal("123", result);
        }

        [Fact]
        public void UnderAgErrorMessage()
        {
            string result = ExamQuestion_2.RegisterUser(15);
            Assert.Equal("User must be at least 18 to register.", result);
        }

        [Fact]
        public void RegisterUserValidAge()
        {
            string result = ExamQuestion_2.RegisterUser(25);
            Assert.Equal("Registration successful.", result);
        }
    }
}
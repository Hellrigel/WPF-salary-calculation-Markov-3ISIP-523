using Microsoft.VisualStudio.TestTools.UnitTesting;
using TKtestMarkov; 
using System;

namespace TKtestMarkov.Tests
{
    [TestClass]
    public class SalaryCalculatorTests
    {
        [TestMethod]
        public void CalculateSalary_ValidInput_ReturnsCorrectResult()
        {
            double result = SalaryCalculator.CalculateSalary(40, 150);
            Assert.AreEqual(6000, result);
        }

        [TestMethod]
        public void CalculateSalary_NegativeHours_ThrowsException()
        {
            // Assert.ThrowsException доступен только с MSTest
            object value = Assert.ThrowsException<ArgumentException>(() =>
            {
                SalaryCalculator.CalculateSalary(-5, 150);
            });
        }

        [TestMethod]
        public void CalculateTax_WithTax_ReturnsCorrectTax()
        {
            double salary = 6000;
            double tax = SalaryCalculator.CalculateTax(salary, true);
            Assert.AreEqual(780, tax); // 13% от 6000
        }

        [TestMethod]
        public void CalculateTax_WithoutTax_ReturnsZero()
        {
            double salary = 6000;
            double tax = SalaryCalculator.CalculateTax(salary, false);
            Assert.AreEqual(0, tax);
        }
    }
}
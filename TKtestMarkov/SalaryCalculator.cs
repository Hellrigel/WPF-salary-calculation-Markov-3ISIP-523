using System;

namespace TKtestMarkov
{
    public static class SalaryCalculator
    {
        /// <summary>
        /// Расчет зарплаты
        /// </summary>
        public static double CalculateSalary(double hours, double rate)
        {
            if (hours < 0)
                throw new ArgumentException("Часы не могут быть отрицательными");

            return hours * rate;
        }

        /// <summary>
        /// Расчет налога
        /// </summary>
        public static double CalculateTax(double salary, bool withTax)
        {
            if (!withTax)
                return 0;

            return salary * 0.13;
        }
    }
}
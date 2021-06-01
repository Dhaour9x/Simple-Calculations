using System;

namespace DailyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDaysPerMonth = decimal.Parse(Console.ReadLine());
            var dailyEarning = decimal.Parse(Console.ReadLine());
            var USDtoEuro= decimal.Parse(Console.ReadLine());

            var bruttPerMonth = workDaysPerMonth * dailyEarning;
            var bonus = bruttPerMonth * 2.5m;
            var annualSalary = bruttPerMonth * 12 + bonus;
            
            var taxe = annualSalary * 0.25m;
            var annualNettSalary = annualSalary - taxe;
            var salarayInEURO = annualNettSalary * USDtoEuro;

            var monthNettSalaray = salarayInEURO / 365;

            Console.WriteLine(monthNettSalaray);
        }
    }
}

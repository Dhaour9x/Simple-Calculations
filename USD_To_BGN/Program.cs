using System;

namespace USD_To_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The USD amount = ");
            var dollar = double.Parse(Console.ReadLine());
            var bulgarianLevs = dollar * 1.79549;
            var euro = dollar * 1.95583;
            var pound = dollar * 2.53405;
            Console.WriteLine("{0} USD = {1} BGN", dollar, Math.Round(bulgarianLevs, 2));
            Console.WriteLine("{0} USD = {1} EUR", dollar, Math.Round(euro, 2));
            Console.WriteLine("{0} USD = {1} GBP", dollar, Math.Round(pound, 2));
        }
    }
}

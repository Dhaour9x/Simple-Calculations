using System;

namespace DateCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday =");
            var birthDate = DateTime.Parse(Console.ReadLine());
            var output = DateTime.ParseExact(birthDate, "dd-MM-yyyy");//, AddDays(1000));
            
            Console.WriteLine();
        }
    }
}

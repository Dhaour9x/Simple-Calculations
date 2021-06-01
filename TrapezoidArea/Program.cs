using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("b1 = ");
            var base1 = double.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            var base2 = double.Parse(Console.ReadLine());

            Console.Write("h = ");
            var atitude = double.Parse(Console.ReadLine());
            var area = atitude * ((base1 + base2) / 2);
            Console.WriteLine("The area is = "+ area);
        }
    }
}

using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("The area is: {0}", area);
        }
    }
}

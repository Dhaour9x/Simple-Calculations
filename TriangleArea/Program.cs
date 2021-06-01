using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());
            var triangleArea = a * h / 2;
            Console.WriteLine("The triangle area = "+ Math.Round(triangleArea, 2));
        }
    }
}

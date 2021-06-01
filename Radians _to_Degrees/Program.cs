using System;

namespace Radians__to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Angle in rad =");
            var radians = double.Parse(Console.ReadLine());
            var degree = radians * 180 / Math.PI;
            Console.WriteLine("The degree = " + Math.Round(degree));
        }
    }
}

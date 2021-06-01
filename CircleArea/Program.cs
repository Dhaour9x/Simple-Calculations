using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("radius = ");
            var r = double.Parse(Console.ReadLine());
            var circleArea = r * r * Math.PI;
            Console.WriteLine("The circle area = "+ circleArea);
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
        }
    }
}

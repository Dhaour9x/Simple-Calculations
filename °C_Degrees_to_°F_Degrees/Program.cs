using System;

namespace _C_Degrees_to__F_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("°C degree = ");
            var celsius = float.Parse(Console.ReadLine());

            var kalvin = celsius * 1.8 + 32;
            Console.WriteLine("The Kalvin degree =" + Math.Round(kalvin, 2));
        }
    }
}

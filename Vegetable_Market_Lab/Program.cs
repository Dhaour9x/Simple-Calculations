using System;

namespace Vegetable_Market_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the vegetable price =");
            var vegetablePrice = float.Parse(Console.ReadLine());

            Console.Write("Enter the fruit price =");
            var fruitPrice = float.Parse(Console.ReadLine());

            Console.Write("Enter the kilograms of vegetables =");
            var kilogramsOfVegetables = int.Parse(Console.ReadLine());

            Console.Write("Enter the kilograms of fruits =");
            var kilogramsOfFruits = int.Parse(Console.ReadLine());

            var vegetablesCost = vegetablePrice * kilogramsOfVegetables;
            var fruitsCost = fruitPrice * kilogramsOfFruits;
            var total = vegetablesCost + fruitsCost;

            Console.WriteLine("The total is =" + Math.Round(total / 1.94));
        }
    }
}

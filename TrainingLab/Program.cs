using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var workspaceTopRows = Math.Round(length/120);
            var workspaceDownRows = Math.Round((width-100)/70);
            var numberOfPlaces = workspaceTopRows * workspaceDownRows - 3;
            Console.WriteLine(numberOfPlaces);
           
        }
    }
}

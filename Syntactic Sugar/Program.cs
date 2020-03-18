using System;
using System.Collections.Generic;

namespace Syntactic_Sugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var preds = new List<string>()
            {
                "COVID-19",
                "Putin",
            };

            var prey = new List<string>()
            {
                "Women",
                "Democrats",
                "Stupid People"
            };

            var trump = new Bug("Trump", "Stupid", preds, prey);
            Console.WriteLine($"My bugs name is {trump.Name}.");
            Console.WriteLine($"The species of my bug, s{trump.Name}, is {trump.Species}.");
            Console.WriteLine($"This is the list of prey: {trump.PreyList()}.");
            Console.WriteLine($"This is the list of predators: {trump.PredatorList()}.");
        }
    }
}

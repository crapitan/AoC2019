using System;
using System.IO;
using System.Linq;

namespace AoC2019.Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuelCalculator = new FuelCalculator();
            Console.WriteLine("AoCDay1.1");
            var input = File.ReadAllLines(@"..\data\input.txt");
            var numbers = input.Select(s => Convert.ToDecimal(s));

            var totalFuleConsumtion = numbers.Sum(d => fuelCalculator.CalculateForMass(d));
            System.Console.WriteLine($"The amount of fuel needed {totalFuleConsumtion}"); 
        }
    }

    public class FuelCalculator
    {
        public decimal CalculateForMass(decimal mass)
        {
           return Math.Floor((mass/3) - 2);     
        }
    }

}

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

            var totalFuleConsumtion = numbers.Sum(d => fuelCalculator.CalculateForMassWithFuel(d));
            System.Console.WriteLine($"The amount of fuel needed {totalFuleConsumtion}"); 
        }
    }

    public class FuelCalculator
    {
        public decimal CalculateForMass(decimal mass)
        {
            var calculated = Math.Floor((mass/3) - 2); 
            return (calculated < 0) ? 0 : calculated;
        }

        public decimal CalculateForMassWithFuel(decimal mass)
        {
            var fule = CalculateForMass(mass);

            if (fule == 0)
            {
                 return fule;
            }
            else
            {
                return fule + CalculateForMassWithFuel(fule);
            }
        }
    }
}

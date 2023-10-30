using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Program
    {

        class FootballPlayer
        {
            public string Name { get; set; }
            public int ShirtNumber { get; set; }
        }

        class Car
        {
            public string Name { get; set; }
            public int Year { get; set; }
        }
        static void Main(string[] args)
        {
            var players = new[]
{
            new FootballPlayer { Name = "Messi", ShirtNumber = 10 },
            new FootballPlayer { Name = "Ronaldo", ShirtNumber = 7 },
            new FootballPlayer { Name = "Neymar JR", ShirtNumber = 23 }
        };

            var shirtNumbers = players.Select(player => player.ShirtNumber);
            string combinedNumbers = string.Join(", ", shirtNumbers);

            Console.WriteLine("Shirt Numbers: " + combinedNumbers);

            var cars = new List<Car>
        {
            new Car { Name = "Toyota", Year = 2020 },
            new Car { Name = "Nissan", Year = 2022 },
            new Car { Name = "Subaru", Year = 2020 }
        };

            var groupedCars = cars.GroupBy(car => car.Year);

            foreach (var group in groupedCars)
            {
                Console.WriteLine($"Cars from {group.Key}:");
                foreach (var car in group)
                {
                    Console.WriteLine($"{car.Name}");
                }
            }

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(number => number % 2 == 0).ToList();

            Console.WriteLine("Even Numbers:");
            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

            var numbers2 = new List<int> { 50, 75, 110, 90, 120, 80 };

            bool hasNumberGreaterThan100 = numbers.Any(number3 => number3 > 100);

            Console.WriteLine($"Has a number greater than 100: {hasNumberGreaterThan100}");

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");

            // Make a List<> of Car objects.
            List<Car> myCars = new List<Car>()
            {
                new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "vw"},
                new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{ PetName = "Melvin", Color = "white", Speed = 43, Make = "Ford"}
            };

            GetFastCars(myCars);
            Console.WriteLine();

            GetFastBMWs(myCars);


            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            // Find all car objects in the List<>, where the speed is greater than 55.
            var fastCars = from c in myCars where c.Speed >= 55 select c;

            foreach (var car in fastCars)
                Console.WriteLine("{0} is going too fast!", car.PetName);
        }

        static void GetFastBMWs(List<Car> myCars)
        {
            // find fast BMWs!
            IEnumerable<Car> fastCars = from c in myCars where c.Speed >= 90 && c.Make == "BMW" select c;

            foreach (var car in fastCars)
                Console.WriteLine("{0} is going too fast!", car.PetName);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make ="Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2018;

            var Ford = new Car()
            {
                Make = "Ford",
                Model = "Focus",
                Year = 2013
            };
            var Chevy = new Car()
            {
                Make = "Chevy",
                Model = "Impala",
                Year = 2015
            };

            var carList = new List<Car>() { myCar, Ford, Chevy };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{ vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
            
        }
    }
}

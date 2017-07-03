using System;
using System.Collections.Generic;

namespace Speed_Racing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');

                var model = inputLine[0];
                var fuelAmount = double.Parse(inputLine[1]);
                var fuelConsumation = double.Parse(inputLine[2]);

                var car = new Car(model,fuelAmount,fuelConsumation);

                cars.Add(model, car);
            }

            var commandsList = Console.ReadLine();

            while (commandsList!="End")
            {
                var commandsParts = commandsList.Split(' ');

                var carModel = commandsParts[1];
                var distance = double.Parse(commandsParts[2]);

                var currentCar = cars[carModel];

                currentCar.Drive(distance);

                cars[carModel] = currentCar;

                commandsList = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.DistanceTraveled}");
            }
        }
    }
}

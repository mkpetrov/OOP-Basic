using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_Data
{
    class RawData
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');

                var model = inputLine[0];
                var engineSpeed = int.Parse(inputLine[1]);
                var enginePower = int.Parse(inputLine[2]);
                var cargoWeight = int.Parse(inputLine[3]);
                var cargoType = inputLine[4];
                var tire1Pressure = double.Parse(inputLine[5]);
                var tire1Age = int.Parse(inputLine[6]);
                var tire2Pressure = double.Parse(inputLine[7]);
                var tire2Age = int.Parse(inputLine[8]);
                var tire3Pressure = double.Parse(inputLine[9]);
                var tire3Age = int.Parse(inputLine[10]);
                var tire4Pressure = double.Parse(inputLine[11]);
                var tire4Age = int.Parse(inputLine[12]);

                var engine = new Engine
                {
                    Power = enginePower,
                    Speed = engineSpeed
                };

                var cargo = new Cargo
                {
                    Type = cargoType,
                    Weight=cargoWeight
                };

                var tiers = new List<Tire>();

                var firstTire = new Tire
                {
                    Age = tire1Age,
                    Pressuer=tire1Pressure
                };
                tiers.Add(firstTire);
                var secondTire = new Tire
                {
                    Age = tire2Age,
                    Pressuer = tire2Pressure
                };
                tiers.Add(secondTire);
                var thirdTire = new Tire
                {
                    Age = tire3Age,
                    Pressuer = tire3Pressure
                };
                tiers.Add(thirdTire);
                var fourTire = new Tire
                {
                    Age = tire4Age,
                    Pressuer = tire4Pressure
                };
                tiers.Add(fourTire);

                var car = new Car(model,engine,cargo,tiers);

                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command=="fragile")
            {
                var fragileCars = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Where(t => t.Pressuer < 1)
                .FirstOrDefault() != null).ToList();

                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                var flamableCars = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();

                foreach (var car in flamableCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}

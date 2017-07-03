using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    class CarSalesman
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                var inputEngine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var engineModel = inputEngine[0];
                var power = inputEngine[1];
                var displacement = string.Empty;
                var efficiency = string.Empty;
                if (inputEngine.Length == 3)
                {
                    int number;
                    var isNumber = Int32.TryParse(inputEngine[2], out number);

                    if (isNumber)
                    {
                        displacement = inputEngine[2];
                    }
                    else
                    {
                        efficiency = inputEngine[2];
                    }
                }

                if (inputEngine.Length==4)
                {
                    displacement = inputEngine[2];
                    efficiency = inputEngine[3];
                }

                var engine = new Engine(engineModel, power);

                if (displacement.Length>0)
                {
                    engine.Displacement = displacement;
                }
                if (efficiency.Length>0)
                {
                    engine.Efficiency = efficiency;
                }

                engines.Add(engine);
            }

            var m = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                var inputCar=Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var carModel = inputCar[0];
                Engine carEngine = engines.Where(e => e.Model == inputCar[1]).FirstOrDefault();
                var weight = string.Empty;
                var color = string.Empty;

                if (inputCar.Length==3)
                {
                    int number;
                    var isNumber = Int32.TryParse(inputCar[2], out number);

                    if (isNumber)
                    {
                        weight = inputCar[2];
                    }
                    else
                    {
                        color = inputCar[2];
                    }
                }

                if (inputCar.Length==4)
                {
                    weight = inputCar[2];
                    color = inputCar[3];
                }

                var car = new Car(carModel, carEngine);

                if (weight.Length>0)
                {
                    car.Weight = weight;
                }
                if (color.Length>0)
                {
                    car.Color = color;
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}

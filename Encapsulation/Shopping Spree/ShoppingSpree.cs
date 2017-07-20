using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Spree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            var inputPersons = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var inputProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            var people = new List<Person>();
            var products = new List<Product>();
            try
            {
                foreach (var kvp in inputPersons)
                {
                    var inputParts = kvp.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = inputParts[0];
                    var money = double.Parse(inputParts[1]);

                    var person = new Person(name, money);
                    people.Add(person);
                }

                foreach (var kvp in inputProducts)
                {
                    var inputParts = kvp.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = inputParts[0];
                    var cost = double.Parse(inputParts[1]);

                    var product = new Product(name, cost);

                    products.Add(product);
                }

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var commandParts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var personName = commandParts[0];
                    var productName = commandParts[1];

                    var product = products.FirstOrDefault(p => p.Name == productName);

                    try
                    {
                        people.FirstOrDefault(p => p.Name == personName).BuyProduct(product);
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    command = Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            foreach (var per in people)
            {
                Console.WriteLine(per.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Opinion_Poll
{
    class OpinionPoll
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var inputPerson = Console.ReadLine().Split(' ');

                var personName = inputPerson[0];
                var personAge = int.Parse(inputPerson[1]);

                var person = new Person(personName,personAge);

                people.Add(person);
            }

            var result = people.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    class CompanyRoster
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();
            var departmentsInfo = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');

                var name = inputLine[0];
                var salary = double.Parse(inputLine[1]);
                var position = inputLine[2];
                var department = inputLine[3];

                var employee = new Employee(name, salary, position, department);

                if (!departmentsInfo.ContainsKey(department))
                {
                    departmentsInfo[department] = new List<double>();
                }

                departmentsInfo[department].Add(salary);

                if (inputLine.Length>4)
                {
                    if (inputLine.Length==5)
                    {
                        int age;
                        var isAge = Int32.TryParse(inputLine[4], out age);

                        if (isAge)
                        {
                            employee.Age = age;
                        }
                        else
                        {
                            employee.Email = inputLine[4];
                        }
                    }
                    else
                    {
                        employee.Email = inputLine[4];
                        employee.Age = int.Parse(inputLine[5]);
                    }
                }

                employees.Add(employee);
            }

            var result = departmentsInfo.OrderByDescending(d => d.Value.Average()).First();
            var highestAvrgDepartment = result.Key;
            var employeesResult = employees.Where(e => e.Department == highestAvrgDepartment)
                .OrderByDescending(s => s.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {highestAvrgDepartment}");

            foreach (var empl in employeesResult)
            {
                Console.WriteLine($"{empl.Name} {empl.Salary:f2} {empl.Email} {empl.Age}");
            }
        }
    }
}

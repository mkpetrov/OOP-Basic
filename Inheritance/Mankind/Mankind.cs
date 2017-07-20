using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mankind
{
    public static void Main(string[] args)
    {
        try
        {
            var studentInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            var studentFirstName = studentInput[0];
            var studentLastName = studentInput[1];
            var facNumber = studentInput[2];

            var studentHuman = new Human(studentFirstName, studentLastName);
            var student = new Student(studentFirstName, studentLastName, facNumber);

            var workerInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var workerFirstName = workerInput[0];
            var workerLastName = workerInput[1];
            var workerWeekSalary = double.Parse(workerInput[2]);
            var workerHours = double.Parse(workerInput[3]);

            var workerHuman = new Human(workerFirstName, workerLastName);
            var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerHours);

            Console.WriteLine($"First Name: {student.FirstName}");
            Console.WriteLine($"Last Name: {student.LastName}");
            Console.WriteLine($"Faculty number: {student.FacNumber}");
            Console.WriteLine();
            Console.WriteLine($"First Name: {worker.FirstName}");
            Console.WriteLine($"Last Name: {worker.LastName}");
            Console.WriteLine($"Week Salary: {worker.WeekSalary:f2}");
            Console.WriteLine($"Hours per day: {worker.WorkHoursPerDay:f2}");
            Console.WriteLine($"Salary per hour: {worker.SalaryPerHour():f2}");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

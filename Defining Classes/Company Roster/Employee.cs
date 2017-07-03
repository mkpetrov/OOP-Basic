﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    private string name;
    private double salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, double salary, string position, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
        this.Email = "n/a";
        this.Age = -1;
    }

    public string Name

    {

        get

        {

            return this.name;

        }

        set

        {

            this.name = value;

        }

    }



    public double Salary

    {

        get

        {

            return this.salary;

        }

        set

        {

            this.salary = value;

        }

    }



    public string Position

    {

        get

        {

            return this.position;

        }

        set

        {

            this.position = value;

        }

    }



    public string Department

    {

        get

        {

            return this.department;

        }

        set

        {

            this.department = value;

        }

    }



    public string Email

    {

        get

        {

            return this.email;

        }

        set

        {

            this.email = value;

        }

    }



    public int Age

    {

        get

        {

            return this.age;

        }

        set

        {

            this.age = value;

        }

    }
}

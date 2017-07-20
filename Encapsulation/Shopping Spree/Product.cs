﻿using System;

class Product
{
    private string name;
    private double cost;

    public Product(string name,double cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length<1 || value==" ")
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public double Cost
    {
        get
        {
            return this.cost;
        }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.cost = value;
        }
    }
}

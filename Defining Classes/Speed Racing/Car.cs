using System;

class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumation;
    private double distanceTraveled;

    public Car(string model,double fuelAmount,double fuelConsumation)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumation = fuelConsumation;
        this.DistanceTraveled = 0.0;
    }

    public string Model
    {
        get
        {
            return this.model; 
        }
        set
        {
            this.model = value;
        }
    }

    public double FuelAmount
    {
        get
        {
            return this.fuelAmount;
        }
        set
        {
            this.fuelAmount = value;
        }
    }

    public double FuelConsumation
    {
        get
        {
            return this.fuelConsumation;
        }
        set
        {
            this.fuelConsumation = value;
        }
    }

    public double DistanceTraveled
    {
        get
        {
            return this.distanceTraveled;
        }
        set
        {
            this.distanceTraveled = value;
        }
    }

    public void Drive(double distance)
    {
        var neededFuel = this.fuelConsumation * distance;

        if (neededFuel>this.fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.DistanceTraveled += distance;
            this.FuelAmount -= neededFuel;
        }
    }
}

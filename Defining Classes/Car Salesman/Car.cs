using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Car(string model,Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = "n/a";
        this.color = "n/a";
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

    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        set
        {
            this.engine = new Engine(value.Model, value.Power)
            {
                Power = value.Power,
                Model=value.Model,
                Displacement=value.Displacement,
                Efficiency=value.Efficiency
            };
        }
        
    }

    public string Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            this.weight = value;
        }
    }

    public string Color
    {
        get
        {
            return this.color;
        }
        set
        {
            this.color = value;
        }
    }
}

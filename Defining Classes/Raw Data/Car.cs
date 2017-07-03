using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

    public Car(string model,Engine engine,Cargo cargo,List<Tire> tires)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.tires = new List<Tire>(tires);
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
            this.engine = new Engine
            {
                Power = value.Power,
                Speed = value.Speed
            };
        }
    }

    public Cargo Cargo
    {
        get
        {
            return this.cargo;
        }
        set
        {
            this.cargo = new Cargo
            {
                Weight = value.Weight,
                Type = value.Type
            
            };
        }
    }
    public List<Tire> Tires
    {
        get
        {
            return this.tires;
        }
        
    }
}

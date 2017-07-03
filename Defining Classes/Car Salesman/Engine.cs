using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Engine
{
    private string model;
    private string power;
    private string displacement;
    private string efficiency;

    public Engine(string model,string power)
    {
        this.Model = model;
        this.Power = power;
        this.Efficiency = "n/a";
        this.Displacement = "n/a";
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

    public string Power
    {
        get
        {
            return this.power;
        }
        set
        {
            this.power = value;
        }
    }

    public string Displacement
    {
        get
        {
            return this.displacement;
        }
        set
        {
            this.displacement = value;
        }
    }

    public string Efficiency
    {
        get
        {
            return this.efficiency;
        }
        set
        {
            this.efficiency = value;
        }
    }
}

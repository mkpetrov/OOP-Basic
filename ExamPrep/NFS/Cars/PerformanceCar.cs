using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar:Car
{
    private List<string> addons;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
    {
        this.addons = new List<string>();
    }

    public override string ToString()
    {
        var sb=new StringBuilder();

        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
        sb.AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s");
        sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");
        if (addons.Count>0)
        {
            sb.AppendLine($"Add-ons: {string.Join(", ", addons)}");
        }
        else
        {
            sb.AppendLine($"Add-ons: None");
        }

        return sb.ToString().Trim();
    }
}
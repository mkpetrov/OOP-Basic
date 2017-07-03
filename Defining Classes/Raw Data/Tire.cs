using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tire
{
    private double pressuer;
    private int age;

    public double Pressuer
    {
        get
        {
            return this.pressuer;
        }
        set
        {
            this.pressuer = value;
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

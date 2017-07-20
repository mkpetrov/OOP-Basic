public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand,string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.HorsePower = horsePower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public int Durability
    {
        get { return this.durability; }
        set { this.durability = value; }
    }


    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }


    public int Acceleration
    {
        get { return this.acceleration; }
        set { this.acceleration = value; }
    }


    public int HorsePower
    {
        get { return this.horsePower; }
        set { this.horsePower = value; }
    }


    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
        set { this.yearOfProduction = value; }
    }


    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }


    public string Brand
    {
        get { return this.brand; }
        set { this.brand = value; }
    }

    public abstract override string ToString();

}
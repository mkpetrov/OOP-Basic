public class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name,string favoriteFood)
    {
        this.Name = name;
        this.favouriteFood = favoriteFood;
    }

    public string MyProperty
    {
        get { return this.favouriteFood; }
        set { this.favouriteFood = value; }
    }


    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.name} and my favourite food is {this.favouriteFood}";
    }

}
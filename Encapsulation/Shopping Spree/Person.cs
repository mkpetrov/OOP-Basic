using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private double money;
    private List<Product> bagOfProducts;

    public Person(string name,double money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<Product>();
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

    public double Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public IReadOnlyList<Product> BagOfProducts
    {
        get
        {
            return this.bagOfProducts.AsReadOnly();
        }
    }

    public  void BuyProduct(Product product)
    {
        if (product.Cost>this.money)
        {
            throw new InvalidOperationException($"{this.name} can't afford {product.Name}");
        }

        this.bagOfProducts.Add(product);
        this.Money -= product.Cost;
    }

    public override string ToString()
    {
        if (this.BagOfProducts.Count==0)
        {
            return $"{this.Name} - Nothing bought";
        }

        var bagOfProducts = this.bagOfProducts.Select(p => p.Name);

        return $"{this.Name} - {string.Join(", ", bagOfProducts)}";
    }
}

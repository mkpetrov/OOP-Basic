using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Family
{
    public List<Person> members = new List<Person>();

    public Family()
    {
        this.members = new List<Person>();
    }
    public void AddMember(Person member)
    {
        members.Add(member);
    }

    public void GetOldestMember()
    {
        var result = members.OrderByDescending(p => p.age).First();
        Console.WriteLine($"{result.name} {result.age}");
    }
}

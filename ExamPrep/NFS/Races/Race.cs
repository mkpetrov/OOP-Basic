using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;
    private Dictionary<int, Car> winners;

    public Dictionary<int, Car> Winners
    {
        get { return this.winners; }
        set { this.winners = new Dictionary<int, Car>(); }
    }


    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.participants = new Dictionary<int, Car>();
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value; }
    }


    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }


    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public Dictionary<int, Car> Participants
    {
        get { return this.participants; }
        set
        {
            this.participants = new Dictionary<int, Car>();
        }
    }

    public void AddParticipant(int id, Car car)
    {
        participants.Add(id, car);
    }

    public abstract int PerformancePoints(int id);

    public Dictionary<int, Car> AddWinners()
    {
        var winners = this.Participants.OrderByDescending(n => this.PerformancePoints(n.Key)).Take(3).ToDictionary(x=>x.Key,x=>x.Value);

        return this.winners;
    }

    public List<int> Prize()
    {
        var result=new List<int>();
        result.Add(this.PrizePool*50/100);
        result.Add(this.PrizePool*30/100);
        result.Add(this.PrizePool*20/100);

        return result; 
    }

    public string StartRace()
    {
        var sb=new StringBuilder();
        var prizes = Prize();

        sb.AppendLine($"{this.route} - {this.length}");

        var counter = 0;
        foreach (var car in winners)
        {
            var currentCar = car.Value;
            sb.AppendLine($"{counter+1}. {currentCar.Brand} {currentCar.Model} {this.PerformancePoints(car.Key)}PP - ${prizes[counter]}");
        }

        if (participants.Count>0)
        {
            return sb.ToString().Trim();
        }
        else
        {
            return "Cannot start the race with zero participants.";
        }
        
    }
}
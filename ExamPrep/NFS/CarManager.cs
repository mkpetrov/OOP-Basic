using System.Collections.Generic;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars=new Dictionary<int, Car>();
        this.races=new Dictionary<int, Race>();
        this.garage=new Garage();
    }

    public Dictionary<int, Car> Cars
    {
        
        set { this.cars=new Dictionary<int, Car>();}
    }
    public Dictionary<int, Race> Races
    {
        
        set { this.races = new Dictionary<int, Race>(); }
    }

    public Garage Garage
    {
        
        set { this.garage = new Garage(); }
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        Car car;
        
        if (type == "Performance")
        {
            car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            cars.Add(id, car);
        }
        else
        {
            car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            cars.Add(id, car);
        }
    }

    public string Check(int id)
    {
        var currentCar = cars[id];

        return currentCar.ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race race;
        if (type == "Casual")
        {
            race = new CasualRace(length, route, prizePool);
            races.Add(id, race);
        }
        else if (type == "Drag")
        {
            race = new DragRace(length, route, prizePool);
            races.Add(id, race);
        }
        else
        {
            race = new DriftRace(length, route, prizePool);
            races.Add(id, race);
        }
    }

    public void Participate(int carId, int raceId)
    {
        var currentRace = races[raceId];
        var currentCar = cars[carId];

        if (!this.garage.ParkedCars.Contains(carId))
        {
            currentRace.AddParticipant(carId, currentCar);
        }
    }

    public string Start(int id)
    {
        return races[id].StartRace();
    }

    public void Park(int id)
    {
        foreach (var race in races.Values)
        {
            if (race.Participants.ContainsKey(id))
            {
                return;
            }
        }
        this.garage.Park(id);
    }

    public void Unpark(int id)
    {
        this.garage.Unpark(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {

    }
}
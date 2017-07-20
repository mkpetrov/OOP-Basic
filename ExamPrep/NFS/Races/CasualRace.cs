using System.Collections.Generic;

public class CasualRace:Race
{

    public CasualRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override int PerformancePoints(int id)
    {
        var car = this.Participants[id];

        var overallPerformance = (car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability);

        return overallPerformance;
    }
}
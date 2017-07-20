using System.Collections.Generic;

public class DriftRace:Race
{
    public DriftRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override int PerformancePoints(int id)
    {
        var car = this.Participants[id];

        var suspensionPerformance = car.Suspension + car.Durability;

        return suspensionPerformance;
    }
}
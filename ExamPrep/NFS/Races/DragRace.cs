using System.Collections.Generic;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override int PerformancePoints(int id)
    {
        var car = this.Participants[id];

        var enginePerformance = car.HorsePower / car.Acceleration;

        return enginePerformance;
    }
}
using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert laps to miles (1 lap = 50 meters, 1 mile ≈ 1609 meters)
        return (_laps * 50.0) / 1609.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }
}

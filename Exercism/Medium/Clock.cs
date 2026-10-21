public class Clock
{
    private int _minutes;
    public Clock(int hours, int minutes)
    {
        _minutes = (hours * 60 + minutes) % 1440;
        if (_minutes < 0) _minutes += 1440;
    }

    public Clock(int minutes)
    {
        _minutes = minutes % 1440;
        if (_minutes < 0) _minutes += 1440;
    }

    public Clock Add(int minutesToAdd) => new Clock(_minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(_minutes - minutesToSubtract);

    public override string ToString()
    {
        int hours = _minutes / 60;
        int minutes = _minutes % 60;
        return $"{hours:D2}:{minutes:D2}";
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Clock)) return false;
        return this.ToString() == obj.ToString();
    }
}
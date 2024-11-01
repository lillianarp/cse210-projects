
public class Running : Activity
{
    // attributes

    private double _distance;

    // constructor 

    public Running(DateTime date, double activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    // methods

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / LengthInMinutes) * 60;
    }

    public override double CalculatePace()
    {
        return LengthInMinutes / _distance; 
    }

}

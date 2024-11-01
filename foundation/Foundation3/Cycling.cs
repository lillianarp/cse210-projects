
public class Cycling : Activity
{
    // attributes

    private double _speed;

    // constructor 

    public Cycling(DateTime date, double activityLength, double speed) : base(date, activityLength)
    {
        _speed = speed;
    }

    // methods
    public override double CalculateDistance()
    {
        return (_speed * LengthInMinutes) / 60; 
    }

    public override double CalculateSpeed()
    {
        return _speed; 
    }

    public override double CalculatePace()
    {
        double distance = CalculateDistance(); 
        return LengthInMinutes / distance; 
    }


}
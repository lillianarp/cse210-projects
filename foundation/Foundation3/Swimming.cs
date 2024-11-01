
public class Swimming : Activity
{
    // attributes

    private int _laps;

    // constructor 

    public Swimming(DateTime date, double activityLength, int laps) : base(date, activityLength)
    {
        _laps = laps;
    }

    // methods

    public override double CalculateDistance()
    {
        return (_laps * 50) / 1000.0; // laps to kms  
    }

    public override double CalculateSpeed()
    {
        double distance = (_laps * 50) / 1000.0;
        return (distance / LengthInMinutes) * 60; 
    }

    public override double CalculatePace()
    {
        double distance = (_laps * 50) / 1000.0; // distance in kms  
        return LengthInMinutes / distance; 
    }

}   
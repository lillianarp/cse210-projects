
public class Activity
{
    // attributes

    private DateTime _date;
    private double _lengthInMinutes;


    public DateTime Date // make this public for the children
    {
        get { return _date; }
        set { _date = value; }
    }
    
    public double LengthInMinutes // make this public
    {
        get { return _lengthInMinutes; }
        set { _lengthInMinutes = value; }
    }

    // constructor

    public Activity(DateTime date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // methods

    public virtual double CalculateDistance()
    {
        // virtual or abstract? Virtual has a default.
        return 0; // <- default, placeholder
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({LengthInMinutes} min) - " +
            $"Distance: {CalculateDistance():0.0} km, Speed: {CalculateSpeed():0.0} kph, " +
            $"Pace: {CalculatePace():0.0} min per km";
    }

    // method for displaying summary

        public static void DisplaySummaries(List<Activity> activities)
        {
            Console.WriteLine();
            Console.WriteLine("Activity Results:");

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary()); // print to console
            }
            
            Console.WriteLine();
        }

}
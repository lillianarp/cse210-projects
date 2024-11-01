using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // instantiate!

        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 4), 45, 20.0);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 5), 60, 40);

        List<Activity> activities = new List<Activity> { running, cycling, swimming }; 
        
        Activity.DisplaySummaries(activities);
    }

}
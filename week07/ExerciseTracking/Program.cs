using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list to hold all activities
        List<Activity> activities = new List<Activity>();

        // 1. Create a Run (03 Nov, 30 mins, 4.8 km)
        Running run = new Running("03 Nov 2022", 30, 4.8);
        activities.Add(run);

        // 2. Create a Bike Ride (03 Nov, 30 mins, 20 kph speed)
        Cycling bike = new Cycling("03 Nov 2022", 30, 20.0);
        activities.Add(bike);

        // 3. Create a Swim (03 Nov, 30 mins, 20 laps)
        Swimming swim = new Swimming("03 Nov 2022", 30, 20);
        activities.Add(swim);

        // Loop through and display summaries
        Console.WriteLine("Exercise Tracking System:");
        Console.WriteLine("-------------------------");

        foreach (Activity activity in activities)
        {
            // Even though we iterate through "Activity" types,
            // Polymorphism ensures the correct calculations run for each specific type.
            Console.WriteLine(activity.GetSummary());
        }
    }
}
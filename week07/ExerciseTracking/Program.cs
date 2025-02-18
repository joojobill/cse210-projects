class Program
{
    static void Main(string[] args)
    {
        // Create activities
        var running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        var cycling = new Cycling(new DateTime(2022, 11, 3), 30, 9.7);
        var swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        // Store activities in a list
        var activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
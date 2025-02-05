using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

         // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos
        Video video1 = new Video("Introduction to C#", "John Doe", 600);
        Video video2 = new Video("Advanced C# Programming", "Jane Smith", 1200);
        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 900);

        // Add comments to video1
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "Clear and concise."));

        // Add comments to video2
        video2.AddComment(new Comment("User4", "Loved the advanced topics!"));
        video2.AddComment(new Comment("User5", "Could you cover more on LINQ?"));
        video2.AddComment(new Comment("User6", "Excellent explanation."));

        // Add comments to video3
        video3.AddComment(new Comment("User7", "Design patterns made easy!"));
        video3.AddComment(new Comment("User8", "Thanks for the detailed examples."));
        video3.AddComment(new Comment("User9", "This helped me a lot."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine(); // Add a blank line for better readability
        }

        
    }
}
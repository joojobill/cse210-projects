using System;

public class Video 
{
     // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display all comments
    public void DisplayComments()
    {
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
        }
    }
}
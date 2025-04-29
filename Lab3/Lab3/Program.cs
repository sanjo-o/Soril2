using System;
using System.Collections.Generic;

public class Post
{
    // Properties
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }

    // Private fields
    private List<string> comments = new List<string>();
    private int likeCount = 0;

    // Methods
    public void Like()
    {
        likeCount++;
        Console.WriteLine("Post liked! Total likes: " + likeCount);
    }

    public void Comment(string message)
    {
        comments.Add(message);
        Console.WriteLine("New comment added: " + message);
    }

    public void Publish()
    {
        Console.WriteLine("\nPublished Post:");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Date: " + DateTime);
        Console.WriteLine("Likes: " + likeCount);
        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine("- " + comment);
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var post = new Post();
        post.Title = "IT203 - Lab 3";
        post.Description = "Object Oriented Programming in C#.NET ...";
        post.DateTime = DateTime.Now;
        post.Publish();

        // Liking the post
        post.Like();
        post.Like();

        // Adding comments to the post
        post.Comment("This is a great post!");
        post.Comment("Thanks for the information.");

        // Re-publish the post to see updated likes and comments
        post.Publish();

        Console.ReadKey();
    }
}
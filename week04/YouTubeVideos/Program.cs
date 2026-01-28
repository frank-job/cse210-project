using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

      
        Video v1 = new Video("How to Code in C#", "Frank Tech", 600);
        v1.AddComment(new Comment("User123", "Great video!"));
        v1.AddComment(new Comment("CoderGuy", "This helped me so much."));
        v1.AddComment(new Comment("Anon", "Can you make one for Python?"));
        videos.Add(v1);

    
        Video v2 = new Video("Best Ugandan Foods", "Travel Africa", 900);
        v2.AddComment(new Comment("Foodie", "Rolex is the best!"));
        v2.AddComment(new Comment("Traveler", "I want to visit Jinja."));
        v2.AddComment(new Comment("Chef", "Nice recipes."));
        videos.Add(v2);

       
        Video v3 = new Video("Funny Cat Compilation", "MeowTube", 300);
        v3.AddComment(new Comment("CatLover", "So cute!"));
        v3.AddComment(new Comment("DogFan", "Dogs are better."));
        v3.AddComment(new Comment("MemeKing", "LOL at 2:00"));
        videos.Add(v3);

      
        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("--- Comments ---");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine(""); 
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Learn C#", "CodeMaster", 600);
        v1.AddComment(new Comment("Alice", "Great explanation!"));
        v1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        v1.AddComment(new Comment("Charlie", "I finally understand classes."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Top 10 Gaming Tips", "ProGamer", 450);
        v2.AddComment(new Comment("Dave", "These tips are awesome!"));
        v2.AddComment(new Comment("Eve", "Helped me rank up fast."));
        v2.AddComment(new Comment("Frank", "Nice video!"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Workout for Beginners", "FitLife", 900);
        v3.AddComment(new Comment("Grace", "Perfect for starting out."));
        v3.AddComment(new Comment("Henry", "Loved the routine."));
        v3.AddComment(new Comment("Ivy", "Very motivating!"));
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (seconds): " + video.GetLength());
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Charlie", "Loved this video."));
        videos.Add(video1);

        Video video2 = new Video("OOP Concepts", "TechWorld", 720);
        video2.AddComment(new Comment("David", "Great abstraction example."));
        video2.AddComment(new Comment("Emma", "Nicely explained."));
        video2.AddComment(new Comment("Frank", "This helped a lot."));
        videos.Add(video2);

        Video video3 = new Video("C# for Beginners", "LearnFast", 900);
        video3.AddComment(new Comment("Grace", "Perfect for beginners."));
        video3.AddComment(new Comment("Hannah", "Easy to follow."));
        video3.AddComment(new Comment("Ian", "Good pace."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}

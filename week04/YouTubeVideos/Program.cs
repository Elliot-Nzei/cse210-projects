using System;

class Program
{
static void Main()
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create and add videos
        Video video1 = new Video("C# Basics", "CodeAcademy", 600);
        video1.AddComment("Alice", "Great explanation!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "I finally understand methods!");
        videos.Add(video1);

        Video video2 = new Video("OOP Principles", "TechTutor", 720);
        video2.AddComment("David", "Encapsulation is cool!");
        video2.AddComment("Emma", "Thanks for this video!");
        video2.AddComment("Frank", "Well explained!");
        videos.Add(video2);

        Video video3 = new Video("Advanced C#", "DevMaster", 900);
        video3.AddComment("Grace", "This is really detailed!");
        video3.AddComment("Henry", "I learned a lot!");
        video3.AddComment("Ivy", "Waiting for part 2!");
        videos.Add(video3);

        // Display videos
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
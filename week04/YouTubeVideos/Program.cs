using System;
using System.Collections.Generic;

namespace YouTubeVideoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create and add first video
            Video video1 = new Video("How to Cook Pasta", "Chef Mike", 480);
            video1.AddComment(new Comment("Alice", "Looks delicious!"));
            video1.AddComment(new Comment("Bob", "Trying this tonight."));
            video1.AddComment(new Comment("Charlie", "More videos please!"));
            videos.Add(video1);

            // Second video
            Video video2 = new Video("DIY Woodworking", "Tool Guy", 600);
            video2.AddComment(new Comment("Dave", "Very helpful."));
            video2.AddComment(new Comment("Emma", "What kind of wood was that?"));
            video2.AddComment(new Comment("Frank", "Love the craftsmanship."));
            videos.Add(video2);

            // Third video
            Video video3 = new Video("Beginner Guitar Lesson", "Music Master", 900);
            video3.AddComment(new Comment("Grace", "I finally get it!"));
            video3.AddComment(new Comment("Evans", "Best tutorial ever."));
            video3.AddComment(new Comment("Isla", "Subscribed!"));
            videos.Add(video3);

            // Display all video info
            foreach (var video in videos)
            {
                video.DisplayInfo();
            }
        }
    }
}

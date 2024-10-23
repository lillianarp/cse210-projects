using System;

class Program
{
    static void Main(string[] args)
    {
        // Let's make some videos 

        List<Video> videoList = new List<Video>(); // make the list first

        Console.WriteLine(); // to add new line
        Video video1 = new Video("How to make $30k a month on TikTok", "Jason Lee", 590); // make a video
        video1.AddComment(new Comment("Margite", "When can you do this in Europe?")); // remember to add comments to each video
        video1.AddComment(new Comment("Tonemind", "Way too expensive"));
        video1.AddComment(new Comment("RyanCruz", "100 per month for 10 videos? For someone just starting, that's expensive!"));
    
        videoList.Add(video1); // add it to the list

        Video video2 = new Video("I took the Top Ranks Intro AI Course For You", "Tina Huang", 2072); 
        video2.AddComment(new Comment("Wanderer6048", "Loved this style of video!! thank you and yes, please do more videos of this format!"));
        video2.AddComment(new Comment("Testimony201", "Thanks. This helps a lot"));
        video2.AddComment(new Comment("Psych_Shock4370", "Wow what a creative idea"));

        videoList.Add(video2); 

        Video video3 = new Video("Coconut prawn curry + Harissa salmon", "Tish Wonders", 856); 
        video3.AddComment(new Comment("pfuluwanino", "Everything about Tish is just so beautiful."));
        video3.AddComment(new Comment("mthomas73", "Amazing looking recipes can't wait to try them"));

        videoList.Add(video3); 

        // loop through the video list to display each with information

        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo(); // this comes from the Video class
            Console.WriteLine(); // to add new line
        }

    }
}
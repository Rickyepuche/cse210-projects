using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Video vid1 = new Video("How to Cook Pasta", "Chef Mario", 700);
        vid1.SetVideoComment("Richard", "I love the stuff");
        vid1.SetVideoComment("Ben", "This recipe is amazing");
        vid1.SetVideoComment("Lucy", "Can you make a vegan version?");
        _videos.Add(vid1);

        Video vid2 = new Video("Top 10 Coding tips", "CodeMaster", 900);
        vid2.SetVideoComment("Sara", "Very helpful, thanks");
        vid2.SetVideoComment("Mike", "Do a video on Java next pls");
        _videos.Add(vid2);

        Video vid3 = new Video("Travel Blog Paris", "Emily", 1200);
        vid3.SetVideoComment("Richard", "I love the stuff");
        vid3.SetVideoComment("Diana", "Paris is amazing");
        vid3.SetVideoComment("Paul", "when is the next vlog?");
        vid3.SetVideoComment("Chris", "cant wait to leave my country");
        _videos.Add(vid3);

        foreach (Video v in _videos)
        {
            v.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
using System;
using System.Security.Cryptography.X509Certificates;

public class Video{

    public string _videoTitle;
    public string _author;
    public int _length;
    
   
    public List<Comment> _comments = new List<Comment>();

    public List<Video> _videos = new List<Video>();


    public void DisplayVideos(){
         foreach(Video video in _videos){
            Console.WriteLine($"{video._videoTitle}");
        }
    }
    public void Display(){
        Console.WriteLine($"Name: {_videoTitle} {_author} {_length}");
        Console.WriteLine("Comments: ");

        foreach(Comment comment in _comments){
            comment.Display();
        }
    }


}
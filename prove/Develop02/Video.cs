using System;
using System.IO; 

public class Video{

    //public string _date;
    public string _videoTitle;
    public string _videoAuthor;
    public string _userResponse;
    public int _length;   

    public void Display(){

         Console.WriteLine($"{_videoTitle} - {_videoAuthor} Words: {_length} \n \n");
    }


    public void SaveToFileEntry(string filename){

       string putLine = _videoTitle +","+_videoAuthor+","+_userResponse+","+_length;
       
       

    }
}
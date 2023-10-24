using System;
public class Comment
{
    public string _userName;
    public string _comment;
       

    public void Display()
    {
        Console.WriteLine($"{_userName} - {_comment}");
    }

  
}
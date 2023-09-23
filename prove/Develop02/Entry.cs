using System;
using System.IO; 

public class Entry{

    public string _date;
    public string _promp;
    public string _userResponse;
    public int _wordCount;   

    public void Display(){

         Console.WriteLine($"{_date} - {_promp}\n{_userResponse} \n Words: {_wordCount} \n \n");
    }


    public void SaveToFileEntry(string filename){

       string putLine = _date +","+_promp+","+_userResponse+","+_wordCount;
       
       

    }
}
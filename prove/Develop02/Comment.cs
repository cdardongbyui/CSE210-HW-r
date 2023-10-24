using System;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

public class Comment{

    public string _filename;
    public List<Video>_entry = new List<Video>();

    public void Display(){

        foreach(Video entry in _entry){
            entry.Display();
        }
    }

    public void SaveToFile(){
        
        using (StreamWriter outputFile = new StreamWriter(_filename)){
            foreach(Video entry in _entry){
              outputFile.WriteLine (entry._videoTitle +","+entry._videoAuthor +","+entry._length);  
            }
        }
     
    }

    public void LoadFile(){
         try {  
        string[] lines = System.IO.File.ReadAllLines(_filename);


     
            foreach (string line in lines)
        {
            Video entry1 = new Video();
            string[] parts = line.Split(",");

            string date = parts[0];
            string promp = parts[1];
            string userEntry = parts[2];
            string wordsCount = parts[3];


            entry1._videoTitle =date;
            entry1._videoAuthor =promp;
           
            entry1._length = Int32.Parse(wordsCount) ;
            _entry.Add(entry1);

        }
        }catch (Exception e){
           Console.WriteLine("Error: " + e.Message); 
        }
        
    }
}
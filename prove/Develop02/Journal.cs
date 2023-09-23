using System;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

public class Journal{

    public string _filename;
    public List<Entry>_entry = new List<Entry>();

    public void Display(){

        foreach(Entry entry in _entry){
            entry.Display();
        }
    }

    public void SaveToFile(){
        
        using (StreamWriter outputFile = new StreamWriter(_filename)){
            foreach(Entry entry in _entry){
              outputFile.WriteLine (entry._date +","+entry._promp +","+entry._userResponse+","+entry._wordCount);  
            }
        }
     
    }

    public void LoadFile(){
         try {  
        string[] lines = System.IO.File.ReadAllLines(_filename);


     
            foreach (string line in lines)
        {
            Entry entry1 = new Entry();
            string[] parts = line.Split(",");

            string date = parts[0];
            string promp = parts[1];
            string userEntry = parts[2];
            string wordsCount = parts[3];


            entry1._date =date;
            entry1._promp =promp;
            entry1._userResponse = userEntry;
            entry1._wordCount = Int32.Parse(wordsCount) ;
            _entry.Add(entry1);

        }
        }catch (Exception e){
           Console.WriteLine("Error: " + e.Message); 
        }
        
    }
}
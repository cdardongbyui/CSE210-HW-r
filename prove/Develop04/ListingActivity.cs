using System.Runtime.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO; 
/*
Exceeding Requirements
In the method where the user's items are written, 
I added a functionality to save to file with the date and time as the file name
*/
public class ListingActivity : Activity
{
   
    private int _duration;
   List<String> prompts = new List<String>() { 
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
         };
    public ListingActivity(string name, string description, int duration)
        : base(name, description)
    {
       
       _duration = duration;
       
    }
Activity act1 = new Activity();
public void run(){
        Console.Clear();
        Console.WriteLine("Get Redy");
        
        act1.ShowSpinner(_duration);

        Console.WriteLine("List a mane responses you can to the following promp:");
        GetRandomPromp();
        
        
        }

public void GetRandomPromp(){
        int indexPrompt;
        Random rnd = new Random();
        indexPrompt = rnd.Next(0,4);
        string prompt = prompts[indexPrompt];
        Console.WriteLine($"    -----  {prompt}  -----");
        
        act1.simpleCountDown(5);
        Console.WriteLine("\n" );
        GetListFromUser(prompt);
        Console.WriteLine("\n Well Done");
        act1.ShowSpinner(_duration);
        act1.DisplayEndingMessage();
         act1.ShowSpinner(_duration*10);
         Console.Clear();


    }  

public void GetListFromUser(string promp){
    int counter = 0;
   
     DateTime currentTime = DateTime.Now;
    DateTime futureTime = currentTime.AddSeconds(_duration);
    string fileName = "Listing_"+currentTime.ToString("yyyyMMdd_hhmmss")+".txt";
    using (StreamWriter outputFile = new StreamWriter(fileName)){
        outputFile.WriteLine (promp);
        outputFile.WriteLine ("Listing");
    
   
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.WriteLine(">");
            string answare =Console.ReadLine();
            counter++;
            outputFile.WriteLine ($"1 - {answare}");

        }

    
        futureTime = currentTime;
        
        Console.WriteLine($"You Listed {counter} items!!!");
        outputFile.WriteLine ($"You Listed {counter} items!!!");
    }
} 


}
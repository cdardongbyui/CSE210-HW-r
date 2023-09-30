using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Develop03 ");

        Reference reference = new Reference();
        reference._book = "proverbs";
        reference._chapter = 4;
        reference._verse = 6;
        reference._endVerse = 6;

       // reference.GetDisplayText();
        
        Scripture scripture = new Scripture();
        scripture._scripture = "Trust in the LORD with all your heart and lean not on your own understanding; 6 in all your ways acknowledge him, and he will make your paths straight";
        scripture._reference= reference.GetDisplayText();
        
        //scripture.GetDisplayText();

        string option = " ";
        scripture.loadWords();
        while(option !="quite"){
           
            scripture.GetDisplayText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            option = Console.ReadLine();
            //scripture.HideRandomWords(3);
            
            if(scripture.isCompletelyHideen()==false && scripture.countShow()>3){
               scripture.HideRandomWords(3); 
            }
            else{
                 scripture.HideRandomWords(scripture.countShow()); 
                 option="quite";
            }
            
            Console.Clear();
        }

      
        

        
    }
}
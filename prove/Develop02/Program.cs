////Showing Creativity and Exceeding Requirements
///-----Save other information in the journal entry.
///----In the method Jurnal LoadFile() i used the try catch to handle errors  if the file don't exist

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to the Jurnal Program");
        int option =0;

        var promps = new List<string>();  
        promps.Add("Who was the most interesting person I interacted with today?");  
        promps.Add("What was the best part of my day?");  
        promps.Add("How did I see the hand of the Lord in my life today?");  
        promps.Add("What was the strongest emotion I felt today?");  
        promps.Add("If I had one thing I could do over today, what would it be?");  
        string txtPromp ="";
        int indexPromp =0;
        string entryTxt = "";
        Journal myJurnal = new Journal();
        string filename ="";

          do{
            
             Console.WriteLine("Please select one of the following choices");
             Console.WriteLine("1. Write"+
                              "\n 2. Display"+
                              "\n 3. Load"+
                              "\n 4. Save"+
                              "\n 5. Quit \n");
             Console.WriteLine("What wold you like todo?");
             option = Convert.ToInt32( Console.ReadLine());

             switch(option){
                case 1:
                //Selecting de random promp
                     Random r1 = new Random();
                     indexPromp = r1.Next(promps.Count);
                     txtPromp = promps[indexPromp];
                     Console.WriteLine(txtPromp);
                     entryTxt =  Console.ReadLine();

                     string[] words = entryTxt.Split(' ');
                     
                //creating entry
                     Entry entry1 = new Entry();
                //geting date     
                     DateTime theCurrentTime = DateTime.Now;
                     string dateText = theCurrentTime.ToShortDateString();
                
                //adding to list new entry
                     entry1._date =dateText;
                     entry1._promp =txtPromp;
                     entry1._userResponse = entryTxt;
                     entry1._wordCount =words.Length;
                     myJurnal._entry.Add(entry1);
                     break;
                case 2:
                    myJurnal.Display();
                    break;
                case 3:
                    Console.WriteLine("What is the filename to load?");
                    filename =  Console.ReadLine();
                    Console.WriteLine("Loading File ..........");
                    myJurnal._filename = filename;
                    myJurnal.LoadFile();
                    Console.WriteLine("The file was loaded ..........");
                    break;
                case 4:
                    Console.WriteLine("What is the filename?");
                    filename =  Console.ReadLine();
                    Console.WriteLine("Saving File ..........");
                    myJurnal._filename = filename;
                    myJurnal.SaveToFile();
                    Console.WriteLine($"The entries were saved in the file {filename}!!!");
                    break;
                case 5:
                    Console.WriteLine("opcion 5");
                    break;
                default:
                    Console.WriteLine("Escriba una opcion valida");
                    break;        
             }

          }while(option !=5);
        
    }
   
}
 
 
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
        
        Comment myJurnal = new Comment();
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
                
                     Video entry1 = new Video();
                     Console.WriteLine("Enter de Title of de Video:");
                     entry1._videoTitle = Console.ReadLine();
                     Console.WriteLine("Enter de Author of the video:");
                     entry1._videoAuthor =Console.ReadLine();
                     Console.WriteLine("Enter the duration of the video in seconds:");
                     entry1._length = Convert.ToInt32( Console.ReadLine());;
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
 
 
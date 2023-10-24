using System;

class Program
{
   // public List<Video> _video = new List<Video>();
   
    static void Main(string[] args)
    {
         int option =0;
          Video myVideo = new Video();
        do{
           
             Console.WriteLine("Please select one of the following choices");
             Console.WriteLine("1. Create a Video"+
                              "\n 2. Display Video"+
                              "\n 3. Create Video Comment"+
                              "\n 4. Display Video Coments"+
                              "\n 5. Quit \n");
             Console.WriteLine("What wold you like todo?");
             option = Convert.ToInt32( Console.ReadLine());

             switch(option){
                case 1:
                   
                    myVideo._videoTitle = Console.ReadLine();
                    myVideo._author = Console.ReadLine();
                    myVideo._length = 10;

                    myVideo._videos.Add(myVideo);
                     break;
                case 2:
                
                   myVideo.DisplayVideos();
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                default:
                    Console.WriteLine("Escriba una opcion valida");
                    break;        
             }

          }while(option !=5);
        
       

       

        

       /*() Comment comment1 = new Comment();
        comment1._userName = "cdardong";
        comment1._comment = "Es un video muy bueno";
       
       
        myVideo._comments.Add(comment1);
       
       myVideo.DisplayVideos();*/

        //myVideo.Display();
    }
}
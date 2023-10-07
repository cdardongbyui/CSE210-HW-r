public class Activity {

    private  string _name;
    private string _description;
    private int _duration;


    public Activity (){

    }
    public Activity (string name, string description){
        _name = name;
        _description = description;
        
        
    }
    public Activity (string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
        
    }

    public void  DisplayStartingMessage(){

         Console.WriteLine($" Wellcome to the {_name}.\n \n  {_description}");
    }

    public void  DisplayEndingMessage(){

         Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
    }

    public void ShowSpinner(int seconds){
            int duration = seconds *100;
            while (duration > 0){
                Console.Write("|");
                Thread.Sleep(125);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("/");
                Thread.Sleep(125);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("-");
                Thread.Sleep(125);
                Console.Write("\b \b"); // Erase the + character
                duration = duration -500;

            }
            Console.Write("\n ");
           //ShowCountDown(seconds);
    }

    public void ShowCountDown(int seconds){
         int timesLoop = 4;
         int rep = seconds/6;
         int secondsLoop = (seconds/6)*1000;  
         Console.Write("\n"); 
          Thread.Sleep(2000);
        
        while(timesLoop > 0){
             Console.Write($"Breathe in ...{rep}"); 
            int segundos = secondsLoop;
                int repTimes = rep -1;         
                while (segundos > 0){
                 Thread.Sleep(1000);
                 Console.Write("\b \b");  
                 Console.Write($"{repTimes}");
                    segundos = segundos -1000;
                    repTimes = repTimes -1;
                 }
                 repTimes = rep -1;
                 segundos = secondsLoop;
                 
                 Console.Write($"\n Now breathe out ...{rep}"); 
                 while (segundos > 0){
                 Thread.Sleep(1000);
                 Console.Write("\b \b");  
                 Console.Write($"{repTimes}");
                    segundos = segundos -1000;
                    repTimes = repTimes -1;
                 }

            Console.WriteLine("\n");
                 
            timesLoop = timesLoop -1;
        }  
               
        Console.Write("\n Well Done!! \n");
        

    }

    public void simpleCountDown(int seconds){
        
        int segundos = seconds *1000;
        while (segundos > 0){
                 Thread.Sleep(1000);
                 Console.Write("\b \b");  
                 Console.Write($"\r You may begin in: {seconds}");
                    segundos = segundos -1000;
                    seconds--;
                 }


    }
    

}
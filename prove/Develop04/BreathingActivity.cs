public class BreathingActivity : Activity
{
   
    private int _duration;
    // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public BreathingActivity(string name, string description, int duration)
        : base(name, description)
    {
       
       _duration = duration;
       
    }

     public void run(){
        Console.Clear();
        Console.WriteLine("Get Redy");
        Activity act1 = new Activity();
        act1.ShowSpinner(_duration);
        act1.ShowCountDown(_duration);
        act1.ShowSpinner(_duration);
        act1.DisplayEndingMessage();
        act1.ShowSpinner(_duration);
        
        
        
     } 
    }
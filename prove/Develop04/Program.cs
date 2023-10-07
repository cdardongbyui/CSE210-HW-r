using System;


int option = 0;
int duration =0;
int numberCuestions =0;
 Console.Clear();
do
{
   
    Console.WriteLine("Menu Options:");
    Console.WriteLine("     1. Start breathing activity" +
                     "\n     2. Start reflecting activity" +
                     "\n     3. Start listing activity" +
                      "\n     4 Quit \n");
    Console.WriteLine("Select a choice from the menu: ");
    option = Convert.ToInt32(Console.ReadLine());
    
    switch (option)
    {
        case 1:
            Console.Clear();
            Activity activity = new Activity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                     activity.DisplayStartingMessage();
                     
            Console.WriteLine("How long, in seconds, would you like for your session?");
             duration = Convert.ToInt32( Console.ReadLine());

            BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing",duration);  
            breathing.run();
            //breathing.DisplayEndingMessage();

            //activity.ShowSpinner(duration);
            Console.Clear();

    
            break;
        case 2:
            Console.Clear();
            Activity activity2 = new Activity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                     activity2.DisplayStartingMessage();
            
            Console.WriteLine("\n How long, in seconds, would you like for your session?");
             duration = Convert.ToInt32( Console.ReadLine());
             Console.WriteLine("\n How many reflection questions do you want to answer??");
             numberCuestions = Convert.ToInt32( Console.ReadLine());

             ReflectingActivity reflecting = new ReflectingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing",duration,numberCuestions);  
                reflecting.run();

            break;
        case 3:
            Console.Clear();
            Activity activity3 = new Activity("Reflection Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                     activity3.DisplayStartingMessage();
            
            Console.WriteLine("\n How long, in seconds, would you like for your session?");
             duration = Convert.ToInt32( Console.ReadLine());
            
            ListingActivity listing = new ListingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing",duration);  
                listing.run();
            break;
        case 4:
            Console.WriteLine("opcion 5");
            break;
        default:
            Console.WriteLine("Escriba una opcion valida");
            break;
    }

} while (option != 4);

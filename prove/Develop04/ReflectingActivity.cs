using System;
using System.Collections.Generic;
using System.Dynamic;

public class ReflectingActivity: Activity{

    private int _count;

    private int _duration;
    string randmonQ ="";
    List<String> prompts = new List<String>() { 
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
         };

    List<String> questions = new List<String>() { 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
         };     

    public ReflectingActivity(string name, string description, int duration ,int count)
        : base(name, description,duration)
    {
       _duration = duration;
       _count = count;
       
    }

    public void run(){
        Console.Clear();
        Console.WriteLine("Get Redy");
        Activity act1 = new Activity();
        act1.ShowSpinner(_duration);

        Console.WriteLine($"Consider the following promp: cuestions:{_count} \n");
        GetRandomPromp();
         Console.WriteLine("\n When you have something in mind, press enter to continued.");
             randmonQ =  Console.ReadLine();
         Console.WriteLine("\n Now ponder on each of the following questions as they related to this expericence.");
         
         act1.simpleCountDown(5); 

         Console.Clear();
         
         GetRandomQuestions();
         act1.DisplayEndingMessage();
         act1.ShowSpinner(_duration);
        Console.Clear();
        }

    public void GetRandomPromp(){
        int indexPrompt;
        Random rnd = new Random();
        indexPrompt = rnd.Next(0,4);
        string prompt = prompts[indexPrompt];
        Console.WriteLine($"    -----  {prompt}  -----");


    }

    public void GetRandomQuestions(){
        string questionCompare =" "; 
        while (_count>0) {
           int questionTime=_duration*5; 
           int indexQuestion;
            Random rnd = new Random();
            indexQuestion = rnd.Next(0,8);
            string question = questions[indexQuestion];
            if (questionCompare!=question){
                Console.WriteLine($"{question}");
                Activity act1 = new Activity();
                 act1.ShowSpinner(questionTime);
                _count--;
                questionCompare=question;
            }
            
        }

            Console.WriteLine("\n Well Done!!");
    }


       


}
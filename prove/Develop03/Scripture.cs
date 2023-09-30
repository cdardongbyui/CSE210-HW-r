using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Scripture{

    public string _reference;
    public string _scripture; 

    private List<Word> _words = new List<Word>();


    

    public void loadWords(){
      
        foreach (var a in _scripture.Split(" "))
        {
        Word word = new Word();
        word._text=a;
        word._isHidden=false;

        _words.Add(word);
        }
    }

    public Boolean isCompletelyHideen(){
         int i =1;
         int large = _words.Count;
         foreach (Word a in _words){
            if(a._isHidden ==true){
                i++;
            }
          } 

         if(large==i){
            return true;   
         }else{
            return false;
         }   
         

    } 
public int countShow(){
         int i =0;
         int large = _words.Count;
         foreach (Word a in _words){
            if(a._isHidden ==false){
                i++;
            }
          } 

         return  i;  
    
    } 

    public void HideRandomWords(int numberToHide) {
        int large = _words.Count;
        int indexWord=0;
        Random rnd = new Random();
           while (numberToHide!=0){
                indexWord = rnd.Next(0,large);
                Word a = _words[indexWord];
                //Console.WriteLine(a._text);
                
                if (a._isHidden == false){
                _words[indexWord]._text="------";
                _words[indexWord]._isHidden=true;  
                 numberToHide--;  
                } 
                

            }
          
       
    } 
    
     public string GetDisplayText(){
        String variable ="";
        foreach (Word item in _words)
        {
            variable = variable +" "+ item._text;
        }
        Console.WriteLine($"{_reference} {variable}");
       return _scripture;
    }

    




}
using System.Runtime.CompilerServices;

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
         int i =0;
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
    public void HideRandomWords(int numberToHide) {
          
          while (numberToHide!=0){
                Console.WriteLine($"Hola {numberToHide}");
                numberToHide--;
          }
          
          
          /*foreach (Word a in _words){
            Console.WriteLine(a._text);
          } */     
    } 
    
     public string GetDisplayText(){
        Console.WriteLine($"{_reference} {_scripture}");
       return _scripture;
    }

    




}
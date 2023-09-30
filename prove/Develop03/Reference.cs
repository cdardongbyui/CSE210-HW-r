public class Reference {
    
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse =0;

    public Reference()
    {
    }

    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){
        if (_endVerse==0){
            //Console.WriteLine( $"{_book} {_chapter}:{_verse}");
            return  $"{_book} {_chapter}:{_verse}";
        }else{
            //Console.WriteLine(  $"{_book} {_chapter}:{_verse}-{_endVerse}");
            return  $"{_book} {_chapter}:{_verse}-{_endVerse}"; 
        }
       
    }
}
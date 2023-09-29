public class Fraction{

    private int _top_number;
    private int _bottom_number;

    public Fraction(){

        _top_number = 1;
        _bottom_number = 1;       
    }

    public Fraction(int top ){

        _top_number = top;
        _bottom_number = 1;       

    }

    public Fraction(int top, int bottom ){

        _top_number = top;
        _bottom_number = bottom;       

    }
                 
    public string GetFractionString(){
       string val = $"{_top_number}/{_bottom_number}";
        return val;
    }

     public double GetDecimalValue()
    {
       return (double)_top_number / (double)_bottom_number;
    }
}
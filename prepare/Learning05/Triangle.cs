public class Triangle : Shape {

    private double _length;
    private double _width;

    public Triangle(string color, double length, double width): base (color){
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
       return _length * _width;
    }

}
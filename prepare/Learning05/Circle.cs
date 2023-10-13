public class Circle : Shape {

    private double _radius;

    //constructor
    public Circle (string color, double radius):base (color) {
        _radius = radius;

    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }


}

public class Square : Shape
{
    // attributes

    private double _side;

    // constructor

    public Square(string color, double side) : base(color) // set the color from Shape.cs
    {
        _side = side;
    }

    // methods

    public override double GetArea() // make sure we say it's an override 
    {
        return _side * _side; 
    }
}
using System;

public class Rectangle : Shape
{
    private int _width;
    private int _length;
    
    public Rectangle(string color, int width, int length) : base(color)
    {
        _width = width;
        _length = length;
    }
    
    public override double GetArea()
    {
        return _width * _length;
    }
}

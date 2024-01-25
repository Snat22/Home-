using System.Formats.Asn1;

namespace task2;

public class Circle
{
    double _radius;
    double _pi = 3.14;


    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle()
    {
        
    }
    public void SetRadius(double radius)
    {
        System.Console.WriteLine($"{_radius}");
    }

    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return  _pi * _radius * _radius ;     
    }
    public double GetDiameter()
    {
        return _radius * 2;
    }

    public double GetCircumeference()
    {
        return 2 * _pi * _radius;
    }
}

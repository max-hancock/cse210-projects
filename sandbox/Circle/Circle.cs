using System.Formats.Asn1;

class Circle
{
    public double _radius;

    public double GetArea()
    {
        double area = _radius * _radius * 3.14159;
        
        return area;
        
    }

    public double GetCircumference()
    {
        double circumference = 2 * _radius * 3.14159;

        return circumference;
    }
}
namespace Lab5;

public class Circle
{
    private double _radius;
    
    public Circle(double radius) => Radius = radius;

    public double Radius { get => _radius; private set => _radius = value <= 0 ? throw new InvalidRadiusException() : value; }

    public override string ToString() => $"The radius of the circle is {Radius}";
}

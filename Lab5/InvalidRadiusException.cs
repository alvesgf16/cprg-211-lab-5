namespace Lab5;

public class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base("The radius can't be less than or equal to zero") { }

    public InvalidRadiusException(double radius) : base($"The radius {radius} is not valid") { }
}

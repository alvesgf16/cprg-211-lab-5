using Lab5;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(new Circle(10));

        try
        {
            Console.WriteLine(new Circle(-10));
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Console.WriteLine(new Circle(0));
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
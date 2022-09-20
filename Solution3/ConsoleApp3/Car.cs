namespace ConsoleApp3;

public class Car : Vehicle
{
    public Car(double price, double speed, double year, double latitude, double longitude)
        : base(price,speed,year, latitude, longitude)
    {
        Console.WriteLine("You choose a Car");
    }
}
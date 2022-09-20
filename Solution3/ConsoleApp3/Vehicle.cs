namespace ConsoleApp3;

public class Vehicle
{
    public double Price { get; set; }
    public double Speed { get; set; }
    public double Year { get; set; }
    public double Longitude {get; set;}
    public double Latitude {get; set;}
    
    public Vehicle(double price, double speed, double year, double longitude, double latitude)
    {
        Price = price;
        Speed = speed;
        Year = year;
        Latitude = latitude;
        Longitude = longitude;
    }
    

    public virtual void ShowData()
    {
        Console.WriteLine(Price);
        Console.WriteLine(Speed);
        Console.WriteLine(Year);
        Console.WriteLine($"{Longitude}, {Latitude}");
    
    }
}
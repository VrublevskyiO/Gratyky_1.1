namespace ConsoleApp3;

public class Plane : Vehicle
{
    public double Height { get; set; }
    public double PassengersAmount { get; set; }

    public Plane(double price, double speed, double year, double latitude, double longitude, double height, double passengersAmount) : base(price,speed,year, latitude, longitude)
    {
        Height = height;
        PassengersAmount = passengersAmount;
        Console.WriteLine("You choose a Plane");
    }

    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine(Height);
        Console.WriteLine(PassengersAmount);
        
    }
}
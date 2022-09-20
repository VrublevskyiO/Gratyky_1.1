namespace ConsoleApp3;

public class Ship : Vehicle
{
    public string Seaport { get; set; }
    public double PassengersAmount { get; set; }
    
    public Ship(double price, double speed, double year, double latitude, double longitude, string seaport, double passengersAmount)
        : base(price,speed,year, latitude, longitude)
    {
        Seaport = seaport;
        PassengersAmount = passengersAmount;
        Console.WriteLine("You choose a Ship");
    }
    
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine(Seaport);
        Console.WriteLine(PassengersAmount);
    }
}
namespace ConsoleApp3;

public class Vehicle
{
    public double Price { get; set; }
    public double Speed { get; set; }
    public double Year { get; set; }
    public Coordinates Cordinate {get; set;} = new Coordinates();
    
    public Vehicle(double price, double speed, double year, Coordinates coordinate)
    {
        Price = price;
        Speed = speed;
        Year = year;
        Cordinate = coordinate;
        //Console.WriteLine("You choose a simple Vehicle");
    }
    

    public virtual void ShowData()
    {
        Console.WriteLine("{0}, {1}", Speed, Price);
        Console.WriteLine(Speed);
        Console.WriteLine(Year);
        Console.WriteLine(cordinates.Latitude);
        Console.WriteLine(cordinates.Longitude);
    }
}

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

public class Car : Vehicle
{
    public Car(double price, double speed, double year, double latitude, double longitude)
        : base(price,speed,year, latitude, longitude)
    {
        Console.WriteLine("You choose a Car");
    }
}

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
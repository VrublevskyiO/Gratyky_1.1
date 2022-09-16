namespace ConsoleApp4;

public class Address
{
    public int Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public int Apartment { get; set; }
    public int House { get; set; }
    public string Street { get; set; }

    public void ShowFullAddress()     
    {
        var fullAddress =  Country + ", " + City + ", " + Street +", " + House + ", " + Apartment;
        Console.WriteLine(fullAddress);
    }
}
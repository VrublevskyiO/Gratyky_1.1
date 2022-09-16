namespace ConsoleApp4;

public class Program {         
    static void Main(string[] args)
    {
        var instance = new Address()
        {
            Apartment = 9, 
            Index = 23219,
            Country = "Ukraine",
            City = "Kyiv",
            Street = "Antonovych",
            House = 114
        };
        instance.ShowFullAddress();
    }
}
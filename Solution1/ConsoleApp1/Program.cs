// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Enter first side of rectangle: ");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second side of rectangle: ");
        int side2 = Convert.ToInt32(Console.ReadLine());
        
        
        var rec = new Rectangle(side1,side2);
        Console.WriteLine(rec.Perimeter);
        Console.WriteLine(rec.Area);
        System.Console.WriteLine("Result:" +rec.Area +" "+rec.Perimeter);
    }
}
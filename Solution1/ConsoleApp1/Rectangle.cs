
using System;
namespace ConsoleApp1;
public class Rectangle
{
    //Тут у нас два поля
    private double side1;
    private double side2;
    
    //Тут вже два property
    public double Area
    {
        get { return side1 * side2;}
    }
    public double Perimeter
    {
        get
        { return 2 * (side1 + side2);}
    }

    //Тепер ще один конструктор
    public Rectangle (double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
}

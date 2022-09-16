// Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
//и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в гривну.

using System;
using ConsoleApp1;

class Program
{
    static void Main()
    {
        double usd = 41.5;
        double eur = 41;
        double rub = 0.5;
        double uah = 3000;
        Converter august = new Converter(usd, eur, rub);
        
        Console.WriteLine(august.ConvertingUahToEur(uah));
        Console.WriteLine(august.ConvertingUahToUsd(uah));
        Console.WriteLine(august.ConvertingUahToRub(uah));
        Console.WriteLine(august.ConvertingEurToUah(200));
        Console.WriteLine(august.ConvertingUsdToUah(200));
        Console.WriteLine(august.ConvertingRubToUah(2000));
    }
}
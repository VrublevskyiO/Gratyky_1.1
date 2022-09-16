// Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
// Написать программу, которая выводит на экран основные арифметические операции.

using System;
using ConsoleApp1;

class Program
{
    static void Main()
    {
        Console.Write(Calc.Add(3,4));
        Console.Write(Calc.Divide(10,2));
    }
}

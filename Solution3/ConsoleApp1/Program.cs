// Создайте класс Printer.
// В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
// Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и
// вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
// выводились разными цветами.
// Обязательно используйте приведение типов.

using System;
using ConsoleApp1;

class Program
{
    static void Main()
    {
        var text1 = new Printer();
        text1.Print();
        
        var text2 = new SubPrinter();
        text2.Print();
        
        //Don't work with values
    }
}
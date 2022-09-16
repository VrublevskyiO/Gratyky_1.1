// See https://aka.ms/new-console-template for more information

using System;
using ConsoleApp2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Title: ");
        string title = Console.ReadLine();
        Book book = new Book(title);
            
        /*Console.WriteLine("Author: ");
        book.Author = Console.ReadLine();
        
        Console.WriteLine("Content: ");
        book.Content = Console.ReadLine();;
*/
        book.Show();
    }
}

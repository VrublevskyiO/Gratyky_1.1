namespace ConsoleApp2;

public class Author
{
    public string Name { private get; set; }

    public Author(string name)
    {
        Name = name;
    }
    public void ShowAuthor()
    {
        Console.WriteLine(Name);
    }
}
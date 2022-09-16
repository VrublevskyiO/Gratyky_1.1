namespace ConsoleApp2;

public class Book
{
    public Title Title { get; set; }
    public Author Author { get; set; }
    public Content Content { get; set; }

    public Book(string author)//, Content content, Title title)
    {
        this.Author = new Author(author);
        //this.Content = content;
        //this.Title = title;
    }
    
    public void Show()
    {
        this.Author.ShowAuthor();
        //this.Content.Show();
        //this.Title.Show();
    }
}
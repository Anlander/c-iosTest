#nullable disable

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }


    public Book(string Title, string Author, int Pages)
    {
        this.Title = Title;
        this.Author = Author;
        this.Pages = Pages;
    }


    public void GetBookInfo()
    {
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Pages: {Pages}");
    }
}
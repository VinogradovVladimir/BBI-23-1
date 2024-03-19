using System.Collections;
using System.Xml.Schema;
struct Book
{
    public string name { get; private set; }
    public int ISBN { get; private set; }
    public string author { get; private set; }
    public int year { get; private set; }
    public Book(string n, int i, string a, int y)
    {
        name = n;
        ISBN = i;
        author = a;
        year = y;
    }
    public void Print()
    {
        Console.Write("\nИмя: {0,-20}", $"{name}");
        Console.Write("Автор: {0,-20}", $"{author}");
        Console.Write("Год: {0,-20}", $"{year}");
    }
}
class Program
{
    private void Author(Book[] b, string a)
    {
        for (int i = 0; i < b.Length; i++)
            if (b[i].author == a)
            {
                b[i].Print();
            }
    }
    private void Date(Book[] b, int y)
    {
        for (int i = 0; i < b.Length; i++)
            if ((b[i].year < y*100) && ((y - 1) * 100 <= b[i].year))
            {
                b[i].Print();
            }
    }
    public static void Main(String[] args)
    {
        //для проверки можете ввести 5-того автора и 20 век - они повторяются
        Book[] books = new Book[10] { 
            new Book("1", 1, "1", 1020), 
            new Book("2", 1, "2", 1120), 
            new Book("3", 1, "3", 1220), 
            new Book("4", 1, "4", 1320), 
            new Book("5", 1, "5", 1420),
            new Book("6", 1, "6", 1900),
            new Book("7", 1, "7", 1620),
            new Book("8", 1, "8", 1720),
            new Book("9", 1, "5", 1820),
            new Book("10", 1, "10", 1920)};
        var author = new Program();
        for (int i = 0; i < books.Length; i++) books[i].Print();
        Console.Write("\nВведите имя автора: ");
        string a = Console.ReadLine();
        author.Author(books, a);
        Console.Write("\nВведите век написания : ");
        int y = int.Parse(Console.ReadLine());
        author.Date(books, y);
    }
}

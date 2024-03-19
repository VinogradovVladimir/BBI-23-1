using System.Collections;
using System.Xml.Schema;
abstract class Book
{
    public string name { get; private set; }
    public int ISBN { get; private set; }
    public string author { get; private set; }
    public int year { get; private set; }
    protected int price;
    public Book(string n, int i, string a, int y, int p)
    {
        name = n;
        ISBN = i;
        author = a;
        year = y;
        price = p;
    }
    public virtual void Price()
    {
        price = price;
    }
    public void Print()
    {
        Console.Write("\nИмя: {0,-20}", $"{name}");
        Console.Write("Автор: {0,-20}", $"{author}");
        Console.Write("Год: {0,-20}", $"{year}");
        Console.Write("Цена: {0,-20}", $"{price}");
    }
    public int pprice => price;
}
class PaperBook : Book
{
    public bool binding { get; private set; }
    public PaperBook(string n, int i, string a, int y, int p, bool b) : base(n, i, a, y, p)
    {
        binding = b;
    }
    public override void Price()
    {
        if (binding) price = price + 300;
        else price = price;
    }
}
class ElectronicBook : Book
{
    public string format { get; private set; }
    public ElectronicBook(string n, int i, string a, int y, int p, string f) : base(n, i, a, y, p)
    {
        format = f;
    }
    public override void Price()
    {
        if (format == "pdf") price = price;
        if (format == "fb2") price = price + 300;
        if (format == "epub") price = price + 500;
    }
}
class AudioBook : Book
{
    public bool studio { get; private set; }
    public AudioBook(string n, int i, string a, int y, int p, bool s) : base(n, i, a, y, p)
    {
        studio = s;
    }
    public override void Price()
    {
        if (studio) price = price + 300;
        else price = price;
    }
}
class Program
{
    private Book[] Sort(Book[] d)
    {
        for (int i = 0; i < d.Length; i++)
        {
            int max = d[i].pprice;
            int index = i;
            Book swapper = d[i];
            bool flag = false;

            for (int j = i + 1; j < d.Length; j++)
            {
                if (d[j].pprice > max)
                {
                    flag = true;
                    max = d[j].pprice;
                    index = j;
                }
            }
            if (flag)
            {
                d[i] = d[index];
                d[index] = swapper;
            }
        }
        return d;
    }
    public static void Main(String[] args)
    {
        //для проверки можете ввести 5 автора и 20 век - они повторяются
        PaperBook[] PaperBook = new PaperBook[5] {
            new PaperBook("PaperBook 1", 1, "1", 1020, 1100, false),
            new PaperBook("PaperBook 2", 1, "2", 1120, 1100, true),
            new PaperBook("PaperBook 3", 1, "3", 1220, 1200, false),
            new PaperBook("PaperBook 4", 1, "4", 1320, 1200, true),
            new PaperBook("PaperBook 5", 1, "5", 1420, 1300, false)};
        ElectronicBook[] ElectronicBook = new ElectronicBook[5] {
            new ElectronicBook("ElectronicBook 1", 1, "1", 1020, 200, "pdf"),
            new ElectronicBook("ElectronicBook 2", 1, "2", 1120, 200, "fb2"),
            new ElectronicBook("ElectronicBook 3", 1, "3", 1220, 300, "pdf"),
            new ElectronicBook("ElectronicBook 4", 1, "4", 1320, 300, "fb2"),
            new ElectronicBook("ElectronicBook 5", 1, "5", 1420, 500, "epub")};
        AudioBook[] AudioBook = new AudioBook[5] {
            new AudioBook("AudioBook 1", 1, "1", 1020, 200, false),
            new AudioBook("AudioBook 2", 1, "2", 1120, 200, true),
            new AudioBook("AudioBook 3", 1, "3", 1220,300, false),
            new AudioBook("AudioBook 4", 1, "4", 1320, 300, true),
            new AudioBook("AudioBook 5", 1, "5", 1420, 400, false)};

        var sort = new Program();
        Book[] t1, t2, t3;
        t1 = sort.Sort((Book[])PaperBook);
        t2 = sort.Sort((Book[])ElectronicBook);
        t3 = sort.Sort((Book[])AudioBook);

        for (int i = 0; i < t1.Length; i++) t1[i].Print();
        Console.WriteLine();
        for (int i = 0; i < t2.Length; i++) t2[i].Print();
        Console.WriteLine();
        for (int i = 0; i < t3.Length; i++) t3[i].Print();
        int k = 0;
        Book[] t = new Book[t1.Length + t2.Length + t3.Length];
        for (int j = 0; j < t1.Length; j++) { t[k] = t1[j]; k++; }
        for (int j = 0; j < t2.Length; j++) { t[k] = t2[j]; k++; }
        for (int j = 0; j < t3.Length; j++) { t[k] = t3[j]; k++; }
        t = sort.Sort(t);
        Console.WriteLine();
        for (int i = 0; i < t.Length; i++) t[i].Print();
    }
}




using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

abstract class Task
{
    protected string text;
    public string Text
    {
        get => text;
        protected set => text = value;
    }
    public Task(string text)
    {
        this.text = text;
    }
}

class Task1 : Task
{
    [JsonConstructor]
    public Task1(string text) : base(text) { }
    public override string ToString()
    {
        return $"{text}\nУникальных слов: {CountUniqueWords()}";
    }

    private int CountUniqueWords()
    {
        string[] words = text.Split(new char[] { ' ', '\n', '\t', '\r', ',', '.', '!', '?' });

        int uniqueWordCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < words.Length; j++)
            {
                if ((i != j) && (words[i].ToLower() == words[j].ToLower()))
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                uniqueWordCount++;
            }
        }

        return uniqueWordCount;
    }
}
class Task2 : Task
{
    [JsonConstructor]
    public Task2(string text) : base(text) { }
    public override string ToString()
    {
        return $"{text}\nСамое длинное слово: {LongestWord()}";
    }

    private string LongestWord()
    {
        string[] words = text.Split(new char[] { ' ', '\n', '\t', '\r', ',', '.', '!', '?' });

        string longestWord = words[0];
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }

        return longestWord;
    }
}
class Json
{
    public static void Write<T>(T obj, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static T Read<T>(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(fs);
        }
        return default(T);
    }
}
    class Program
{
    static void Main()
    {
        Console.Write("\tВ самом приложении:\n");
        string text = "A a B baa cscddsd";
        Task[] tasks = {new Task1(text), new Task2(text)};
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);

        string path = @"C:\Users\m2303258\Downloads";
        string folderName = "Test";
        path = Path.Combine(path, folderName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string Name1 = "task_1.json";
        string Name2 = "task_2.json";
        Console.Write("\n\tДесереализованные файлы:\n");
        Name1 = Path.Combine(path, Name1);
        Name2 = Path.Combine(path, Name2);

        if (!File.Exists(Name1)) 
        {
            Json.Write<Task1>((Task1)tasks[0], Name1);
            Json.Write<Task2>((Task2)tasks[1], Name2);   
        }
        else
        {
            var t1 = Json.Read<Task1>(Name1);
            var t2 = Json.Read<Task2>(Name2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
abstract class Task
{
    private string _text;
    public Task(string text) { _text = text; }
    public virtual string ToString()
    {
        return _text;
    }
}

class Task_13 : Task
{
    private string _text;
    public Task_13(string t) : base(t) { _text = t; }
    struct Statistic
    { 
        public char letter;
        public int count;
        public Statistic(char l, int c)
        {
            letter = l;
            count = c;
        }
    }
    public override string ToString()
    {
        string[] words = _text.Split(' ');
        Statistic[] letters = new Statistic[words.Length] ;
        letters = Create(letters, words);
        Show(letters, words);
        return _text;
    }
    private Statistic[] Create(Statistic[] letters, string[] words)
    {
        int k = 0;
        for (int i = 0; i < words.Length; i++)
        {
            bool have = false;
            for (int j=0; j < k; j++)
            {
                if (char.ToLower(words[i][0]) == letters[j].letter)
                { 
                    letters[j].count++;
                    have = true;
                    break;
                }
            }
            if (!have)
            {
                letters[k].letter = char.ToLower(words[i][0]);
                letters[k].count=1;
                k++;
            }

        }
        return letters;
    }
    private void Show(Statistic[] letters, string[] words)
    {
        foreach (var i in letters)
        {
            if (i.count != 0) Console.WriteLine($"Буква: {i.letter}, Процент встреч: {(100 * (double)i.count) / (double)words.Length}%");
            else break;
        }
    }
}

public class Program
{


    public static void Main(string[] args)
    {
        //13
        Console.WriteLine("Задание№13.Введите текст");
        string text = Console.ReadLine();
        var task13 = new Task_13(text);
        Console.Write("\n{0}", task13.ToString());


    }
}
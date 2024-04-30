
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
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
        public char letter { get; private set; }
        public int count { get; private set; }
        /*        public Statistic(char l, int c)
                {
                    letter = l;
                    count = c;
                }*/
        public void add()
        {
            count++;
        }
        public void create(char l)
        {
            letter = l;
            count = 1;
        }
    }
    public override string ToString()
    {
        string[] words = _text.Split(' ');
        Statistic[] letters = new Statistic[words.Length];
        letters = Create(letters, words);
        Show(letters, words);
        return _text;
    }
    private Statistic[] Create(Statistic[] letters, string[] words)
    {
        int k = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (char.IsLetter(char.ToLower(words[i][0])))
            {
                bool have = false;
                for (int j = 0; j < k; j++)
                {
                    if ((char.ToLower(words[i][0]) == letters[j].letter))
                    {
                        letters[j].add();
                        have = true;
                        break;
                    }
                }
                if (!have)
                {
                    letters[k].create(char.ToLower(words[i][0]));
                    k++;
                }
            }
        }
        return letters;
    }
    /*    private Statistic[] Create(Statistic[] letters, string[] words)
        {
            int k = 0;
            for (int i = 0; i < words.Length; i++)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(words[i][0]);
                if (category==UnicodeCategory.UppercaseLetter || category==UnicodeCategory.LowercaseLetter)
                {
                    bool have = false;
                    for (int j = 0; j < k; j++)
                    {
                        if ((char.ToLower(words[i][0]) == letters[j].letter))
                        {
                            letters[j].add();
                            have = true;
                            break;
                        }
                    }
                    if (!have)
                    {
                        letters[k].create(char.ToLower(words[i][0]));
                        k++;
                    }
                }
            }
            return letters;
        }*/


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
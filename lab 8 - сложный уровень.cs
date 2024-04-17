
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
using static System.Net.Mime.MediaTypeNames;
abstract class Task
{
    public Task(string text) { }
    protected abstract string ParseText(string text, string[] code);
    public virtual void Print(string text, string[] code)
    {
        Console.Write(text);
    }
}
class Task_8 : Task
{
    public Task_8(string t) : base(t) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public override void Print(string text, string[] code)
    {
        text = ParseText(text, code);
        Console.Write("\nЗадание№8\n{0}", text);
    }


    protected override string ParseText(string text, string[] code)
    {
        int j = 0;
        while (j < text.Length - 50)
        {
            int i = j + 50;
            while (i > j && text[i] != ' ')
            {
                i--;
            }

            if (i == j)
            {
                i = j + 50;
            }
            text = text.Remove(i, 1);
            text = text.Insert(i, "\n");
            int d = 0;
            string text1 = text.Substring(j, i - j);
            while (text1.Length < 50)
            {
                for (int l = j; l < i; l++)
                {
                    if (text[l] == ' ')
                    {
                        text = text.Insert(l, " ");
                        l++;
                        d++;
                        text1 = text.Substring(j, i + d - j);
                        if (text1.Length >= 50) break;
                    }
                }
            }
            j = i + 1 + d;
        }

        return text;
    }
}
class Task_9 : Task
{
    public Task_9(string t) : base(t) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public override void Print(string text, string[] code)
    {
        Console.Write("\n\nЗадание№9");
        text = ParseText(text   , code);
        Console.Write("\nРезультат: \n{0}", text);
    }
    protected override string ParseText(string text, string[] code)
    {
        Dictionary<string, int> letter = new Dictionary<string, int>();
        for (int i = 65; i < 91; i++)
        {
            for (int j = 65; j < 91; j++)
            {
                char first = char.ToLower((char)i);
                char second = char.ToLower((char)j);
                string key = first.ToString() + second.ToString();
                letter.Add(key, 0);
            }
        }
        for (int i = 0; i < text.Length - 1; i++)
        {
            string two = text[i].ToString() + text[i + 1].ToString();
            if (letter.ContainsKey(two))
            {
                letter[two]++;
            }
        }
        string[] keys = new string[10];
        int max = 0;
        for (int j = 0; j < 10; j++)
        {
            max = 0;
            foreach (var i in letter)
            {
                bool est = true;
                if ((i.Value > max))
                {
                    for (int z = 0; z < j; z++)
                    {
                        if (i.Key == keys[z])
                        {
                            est = false;
                            break;
                        }
                    }
                    if (est)
                    {
                        max = i.Value;
                        keys[j] = i.Key;
                    }
                }
            }
        }
        char[] kode = new char[10];
        int k = 0;

        for (int i = 33; i < 125; i++)
        {
            bool pod = true;
            for (int j = 0; j < text.Length; j++)
            {
                if ((char)i == (char)text[j])
                {
                    pod = false;
                    break;
                }
            }
            if (pod)
            {
                kode[k] = (char)i;
                k++;
            }
            if (k == 10) break;
        }
        Console.WriteLine("\n\nТаблица символов/кодов:");
        for (int j = 0; j < keys.Length; j++)
        {
            Console.Write("\t {0}", keys[j]);
        }
        Console.WriteLine();
        for (int j = 0; j < 10; j++)
        {
            Console.Write("\t {0}", kode[j]);
        }
        int l = keys.Length;
        if (l>text.Length) l= text.Length;
        for (int j = 0; j < l; j++)
        {
            if (keys[j] != null)
            {
                text = text.Replace(char.ToUpper(keys[j][0]).ToString() + (keys[j][1]).ToString(), kode[j].ToString());
                text = text.Replace((keys[j][0]).ToString() + char.ToUpper(keys[j][1]).ToString(), kode[j].ToString());
                text = text.Replace(char.ToUpper(keys[j][0]).ToString() + char.ToUpper(keys[j][1]).ToString(), kode[j].ToString());
                text = text.Replace(keys[j], kode[j].ToString());
            }
        }
        return text;
    }

}
class Task_10 : Task
{
    public Task_10(string t) : base(t) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public override void Print(string text, string[] code)
    {
        text = ParseText(text, code);
        Console.Write("\nРезультат:\n{0}", text);
    }
    protected override string ParseText(string text, string[] code)
    {
        for (int j = 0; j < code.Length; j=j+2)
        {
            text = text.Replace(code[j], code[j + 1]);
        }
        return text;
    }
}
class Task_12 : Task
{
    public Task_12(string t) : base(t) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public override void Print(string text, string[] code)
    {
        text = ParseText(text, code);
        Console.Write("\nРезультат:\n{0}", text);
    }
    protected override string ParseText(string text, string[] code)
    {
        Dictionary<string, char> codes = new Dictionary<string, char>
{
    {"you", '@'},
    {"as", '#'},
    {"his", '$'},
    {"which", '%'},
    {"do", '^'},
    {"that", '&'},
    {"he", '*'},
    {"if", '('},
    {"will", ')'},
    {"how", '-'},
    {"said", '_'},
    {"an", '='},
    {"on", '+'},
    {"tell", '{'},
    {"set", '['},
    {"at", ']'},
    {"by", ':'},
    {"well", '"'},
    {"also", '\\'},
    {"play", '<'},
    {"can", '>'},
    {"end", ','},
    {"put", '.'},
    {"home", '?'},
    {"read", '/'},
    {"hand", '|'},
    {"out", '`'},
    {"I", '~'},
    };
        string[] mas = text.Split(' ');
        // for(int i=0; i<mas.Length; i++) Console.WriteLine(mas[i]);
        for (int i = 0; i < mas.Length; i++)
        {
            foreach (var z in codes)
            {
                mas[i] = mas[i].Replace(z.Key.ToString(), z.Value.ToString());
            }
        }
        Console.WriteLine("Заменённый слова из массива");
        for (int i = 0; i < mas.Length; i++) Console.Write("{0} ", mas[i]);
        for (int i = 0; i < mas.Length; i++)
        {
            foreach (var z in codes)
            {
                mas[i] = mas[i].Replace(z.Value.ToString(), z.Key.ToString());
            }
        }
        return String.Join(" ", text);
    }
}
class Task_13 : Task
{
    public Task_13(string t) : base(t) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public override void Print(string text, string[] code)
    {
        Console.WriteLine("\n\nЗадание№13");
        text = ParseText(text, code);
    }
    protected override string ParseText(string text, string[] code)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (!letters.ContainsKey(words[i][0]))
                letters.Add(words[i][0], 0);
        }
        for (int i = 0; i < words.Length; i++)
        {
            letters[words[i][0]]= (letters[words[i][0]]+1);
        }
        foreach (var i in letters)
        {
            Console.WriteLine($"Буква: {i.Key}, Процент встреч: {100*i.Value/ words.Length}%");
        }
        return text;
    }
}
class Task_15 : Task
{
    public Task_15(string t) : base(t) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public override void Print(string text, string[] code)
    {
        text = ParseText(text, code);
        Console.WriteLine("\nРезультат сложения: {0}", text);
    }
    protected override string ParseText(string text, string[] code)
    {
        string[] numbers= new string[text.Length];
        string number = "";
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (((int)(char)text[i] > 47) && (int)(char)text[i] < 58)
            {
                number += text[i].ToString();
                numbers[count] = number;
            }
            else
            {
                 number = "";
                count++;
            }
        }
        count = 0;
        foreach (var i in numbers)
        {
            if ((i != "")&&(i!=null)) count += int.Parse(i);
        }
        text = count.ToString();
        return text;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст для 8 и 9 номера.\nДля корректной работы 9 номера введите английский текст");
        string text = Console.ReadLine();
        string[] code = new string[10];
        var task8 = new Task_8("");
        var task9 = new Task_9("");
        task8.Print(text, code);
        task9.Print(text, code);

        var task10 = new Task_10("");
        Console.WriteLine("\n\nЗадание№10\nВведите закодированный текст");
        text = Console.ReadLine();
        Console.WriteLine("\n Задайте таблицу для 5 кодов");
        for (int i = 0; i < 10; i++)
        {

            Console.Write("Символ или набор симоволов из текста: ");
            string input = Console.ReadLine();
            if (input.Length > 0)
            {
                code[i] = input;
                Console.Write("Раскодировка {0} : ", code[i]);
                code[i + 1] = Console.ReadLine();
                i++;
            }
            else
            {
                Console.WriteLine("Вы не ввели символ. Повторите попытку.");
                i--; // Уменьшаем счетчик, чтобы повторно запросить ввод
            }
        }
        task10.Print(text, code);

        Console.WriteLine("\n\nЗадание№12\nВведите текст (пример текста с кодовыми словами - you, as. which, do, he, if, how said an tell at by )");
        text = Console.ReadLine();
        var task12 = new Task_12("");
        task12.Print(text, code);
        var task13 = new Task_13("");
        task13.Print(text, code);

        Console.WriteLine("\n\nЗадание№15\nВведите текст с числами");
        text = Console.ReadLine();
        var task15 = new Task_15("");
        task15.Print(text, code);
    }
}

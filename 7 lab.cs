using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region 1_1
class Results
{
    public string name { get; private set; }
    private string society;
    public double result1 { get; private set; }
    //private double result1;
    public double result2 { get; private set; }
    //private double result2;
    public bool disqualification { get; private set; }
    public Results(string n, string s, double r1, double r2)
    {
        name = n;
        society = s;
        result1 = r1;
        result2 = r2;
        disqualification = false;
    }
    public void display()
    {
        if (!disqualification)
        {
            Console.Write("\n{0, -20}", $"{name}");
            Console.Write("{0, -20}", $"{society}");
            Console.Write("{0, -20}", $"{result1}");
            Console.Write("{0, -20}", $"{result2}");
        }
    }
    public void Disqualification()
    {
        if (Console.ReadLine() == "да") { disqualification = true; }
    }
}
public class Program
{
    private Results[] Sort(Results[] table)
    {
        double max;
        int index;
        Results switcher;
        for (int i = 0; i < table.Length - 1; i++)
        {
            bool flag = false;
            max = (table[i].result1 + table[i].result2);
            index = i;
            for (int j = i + 1; j < table.Length; j++)
            {
                if ((table[j].result1 + table[j].result2) > max)
                {
                    max = (table[j].result1 + table[j].result2);
                    index = j;
                    flag = true;
                }
            }
            if (flag == true)
            {
                switcher = table[index];
                table[index] = table[i];
                table[i] = switcher;
                flag = false;
            }
        }
        return table;
    }
    public static void Main(string[] args)
    {
        Results[] table = new Results[5]
        {
    new Results("первый", "мисис топ", 2.10, 2.20),
    new Results("второй", "мисис топ 2", 2.40, 1.20),
    new Results("третий", "мисис топ 3", 4.50, 3.00),
    new Results("четвёртый", "мисис топ 4", 2.60, 9.00),
    new Results("пятый", "мисис топ 5", 2.70, 5.00)
        };
        for (int i = 0; i < table.Length; i++)
        {
            Console.Write("Дисквалицировать участиника - '{0}'? Введите 'да' или 'нет': ", table[i].name);
            table[i].Disqualification();
        }
        var sort = new Program();
        table = sort.Sort(table);
        Console.WriteLine("Фамилия:\tОбщество:\tРезультат 1 попытки:\tРезультат 2 попытки: ");
        for (int i = 0; i < table.Length; i++)
        {
            table[i].display();
        }
    }
}
#endregion

#region 2_6
/*public abstract class Jump
{
    protected string _name;
    protected string _discipline;
    protected double[] _mark;
    public double open_sum { get; private set; }
    private double Sum(double[] m)
    {
        double sum = 0;
        for (int i = 0; i < m.Length; i++) sum += m[i];
        return sum;
    }
    public Jump(string name, double[] mark)
    {
        _discipline = null;
        _name = name;
        _mark = mark;
        open_sum = Sum(mark);
    }
    public virtual void display()
    {
        Console.Write("\n{0, -18}", $"{_name}");
        for (int i = 0; i < _mark.Length; i++) Console.Write("{0, -17}", $"{_mark[i]}");
    }
}
class three_meters : Jump
{
    public three_meters(string name, double[] mark) : base(name, mark)
    {
        _discipline = "three";
    }
    public override void display()
    {
        Console.Write("\n{0, -18}", $"C 3м - {_name}");
        for (int i = 0; i < _mark.Length; i++) Console.Write("{0, -17}", $"{_mark[i]}");
    }
}
class five_meters : Jump
{
    public five_meters(string name, double[] mark) : base(name, mark)
    {
        _discipline = "five";
    }
    public override void display()
    {
        Console.Write("\n{0, -18}", $"C 5м - {_name}");
        for (int i = 0; i < _mark.Length; i++) Console.Write("{0, -17}", $"{_mark[i]}");
    }
}
public class Program
{
    private Jump[] Sort(Jump[] table)
    {
        double max;
        int index;
        Jump switcher;
        for (int i = 0; i < table.Length - 1; i++)
        {
            bool flag = false;
            max = table[i].open_sum;
            index = i;
            for (int j = i + 1; j < table.Length; j++)
            {
                if (table[j].open_sum > max)
                {
                    max = table[j].open_sum;
                    index = j;
                    flag = true;
                }
            }
            if (flag == true)
            {
                switcher = table[index];
                table[index] = table[i];
                table[i] = switcher;
                flag = false;
            }
        }
        return table;
    }
    public static void Main(string[] args)
    {
        Jump[] table = new Jump[5]
        {
 new three_meters("первый", new double [] {1, 2,3,4,444 }),
 new three_meters("второй", new double [] { 1, 2, 3, 4, 55 }),
 new five_meters("третий", new double [] { 1, 2, 3, 4, 3 }),
 new five_meters ("четвёртый", new double[] { 1, 2, 3, 4, 50 }),
 new five_meters ("пятый", new double[] { 1, 2, 3, 4, 5 })
        };
        var z = new Program();
        z.Sort(table);
        Console.WriteLine("   Фамилия:\tОценка№1:\tОценка№2\tОценка№3\tОценка№4\tОценка№5");
        for (int i = 0; i < table.Length; i++)
        {
            table[i].display();
        }
    }
}*/
#endregion

#region 3_6
/*
public abstract class Country
{
    public string[] answer { get; private set; }
    public double[] count { get; private set; }
    public Country(string[] a, double[] c)
    {
        answer = a;
        count = c;
    }
    public void display(int number)
    {
        Console.Write("\n{0, -15}", $"Ответ - '{answer[number]}'");
        Console.Write("{0, -7}", $"{count[number]:f2}%");
    }
}
class Russia : Country
{
    public Russia(string[] answer, double[] count) : base(answer, count)
    {

    }
}
class Japan : Country
{
    public Japan(string[] answer, double[] count) : base(answer, count)
    {

    }
}
public class Program
{
    private Country[] Sort(Country[] table, int number)
    {
        double max;
        int index;
        Country switcher;
        for (int i = 0; i < table.Length - 1; i++)
        {
            bool flag = false;
            max = table[i].count[number];
            index = i;
            for (int j = i + 1; j < table.Length; j++)
            {
                if (table[j].count[number] > max)
                {
                    max = table[j].count[number];
                    index = j;
                    flag = true;
                }
            }
            if (flag == true)
            {
                switcher = table[index];
                table[index] = table[i];
                table[i] = switcher;
                flag = false;
            }
        }
        return table;
    }
    public static void Main(string[] args)
    {
        Console.Write("Введите количество опрошенных - ");
        int count = int.Parse(Console.ReadLine());
        string[] answer_animal = new string[count];
        string[] answer_personality = new string[count];
        string[] answer_thing = new string[count];
        string[] country = new string[count];
        Country[] table = new Country[count];
        int c1=0, c2=0;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\n{0:d} опрошенный. (Вводите информацию с одним регистром)", i + 1);
            Console.Write("Введите страну р/я? - ", i + 1);
            country[i] = Console.ReadLine();
            if (country[i] == "р") c1++;
            if (country[i] == "я") c2++;
            Console.WriteLine(" - Какое животное Вы связываете с Японией и японцами?");
            answer_animal[i] = Console.ReadLine();
            Console.WriteLine(" - Какая черта характера присуща японцам больше всего?");
            answer_personality[i] = Console.ReadLine();
            Console.WriteLine(" - Какой неодушевленный предмет или понятие Вы связываете с Японией ? ");
            answer_thing[i] = Console.ReadLine();
        }
        Russia[] Rus = new Russia[c1];
        Japan[] Jap = new Japan[c2];
        int count_r = 0;
        int count_j = 0;
        for (int i = 0; i < count; i++)
        {
            double k1 = 0, k2 = 0, k3 = 0;
            for (int j = 0; j < count; j++)
            {
                if (answer_animal[i] == answer_animal[j]) k1++;
                if (answer_personality[i] == answer_personality[j]) k2++;
                if (answer_thing[i] == answer_thing[j]) k3++;
            }
            if (country[i] == "р")
            {
                Rus[count_r] = new Russia(new string[] { answer_animal[i], answer_personality[i], answer_thing[i] }, new double[] { (100 * k1 / count), (100 * k2 / count), (100 * k3 / count) });
                count_r++;
            }
            if (country[i] == "я")
            {
                Jap[count_j] = new Japan(new string[] { answer_animal[i], answer_personality[i], answer_thing[i] }, new double[] { (100 * k1 / count), (100 * k2 / count), (100 * k3 / count) });
                count_j++;
            }
            table[i] = (Country) new Russia(new string[] { answer_animal[i], answer_personality[i], answer_thing[i] }, new double[] { (100 * k1 / count), (100 * k2 / count), (100 * k3 / count) });

            //Console.WriteLine($" №1: '{table[i].answer[0]}' {table[i].count[0]:f2}%; №2:'{table[i].answer[1]}' {table[i].count[1]:f2}%; №3:'{table[i].answer[2]}' {table[i].count[2]:f2}%; ");
        }
        //преобразование классов
        Country[] russia = (Country[])Rus;
        Country[] japan = (Country[])Jap;
        var print = new Program();
        Console.Write("\n\n\tПо Миру");
        print.Print(table, count);
        Console.Write("\n\n\tПо России");
        print.Print(russia, count_r);
        Console.Write("\n\n\tПо Японии");
        print.Print(japan, count_j);
    }
    private void Print(Country[] table, int count) {
        Country[] statistic_animal = (Country[])table;
        Country[] statistic_personality = (Country[])table;
        Country[] statistic_thing = (Country[])table;
        //сортируем таблицы по опр. вопросу 
        statistic_animal = Sort(statistic_animal, 0);
        statistic_personality = Sort(statistic_personality, 1);
        statistic_thing = Sort(statistic_thing, 2);
        // for (int i = 0; i < statistic_animal.Length; i++) Console.WriteLine($" №1: '{statistic_animal[i].answer[0]}' {statistic_animal[i].count[0]:f2}%;");
        int k = 5;
        if (k > count) k = count;
        for (int number = 0; number < 3; number++)
        {
            Console.Write("\nВопрос№{0:d}: ", number + 1);
            Country[] fordisplay = new Country[number];
            if (number == 0) fordisplay = statistic_animal;
            if (number == 1) fordisplay = statistic_personality;
            if (number == 2) fordisplay = statistic_thing;
            bool flag = false;
            for (int i = 0; i < k; i++)
            {
                if (i == 0) fordisplay[i].display(number);
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        flag = false;
                        if (fordisplay[i].answer[number] == fordisplay[j].answer[number])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false) fordisplay[i].display(number);
                }
            }
        }
    }
}*/
#endregion

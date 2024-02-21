using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Net.Sockets;
using System.Reflection;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
#region 1_1
struct Results
{
    private string name;
    private string society;
    private double result1;
    private double result2;
    public Results(string n, string s, double r1, double r2)
    {
        name = n;
        society = s;
        result1 = r1;
        result2 = r2;
    }
    public void display()
    {
        Console.Write("\n{0, -20}", $"{name}");
        Console.Write("{0, -20}", $"{society}");
        Console.Write("{0, -20}", $"{result1}");
        Console.Write("{0, -20}", $"{result2}");
    }
    public double open_result1 => result1;
    public double open_result2 => result2;
}
public class Program
{
    public static void Main(string[] args)
    {
        Results[] table = new Results[5]
        {
 new Results("первый", "мисис топ", 2.10, 2.20),
 new Results("второй", "мисис топ 2", 2.40, 2.90),
 new Results("третий", "мисис топ 3", 4.50, 3.00),
 new Results("четвёртый", "мисис топ 4", 2.60, 4.00),
 new Results("пятый", "мисис топ 5", 2.70, 5.00)
        };
        double max;
        int index;
        Results switcher;
        for (int i = 0; i < table.Length - 1; i++)
        {
            bool flag = false;
            max = (table[i].open_result1 + table[i].open_result2);
            index = i;
            for (int j = i + 1; j < table.Length; j++)
            {
                if ((table[j].open_result1 + table[j].open_result2) > max)
                {
                    max = (table[j].open_result1 + table[j].open_result2);
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
        Console.WriteLine("Фамилия:\tОбщество:\tРезультат 1 попытки:\tРезультат 2 попытки: ");
        for (int i = 0; i < table.Length; i++)
        {
            table[i].display();
        }
    }
}
#endregion
#region 2_6
/*struct Results
{
    private string name;
    private double mark1;
    private double mark2;
    private double mark3;
    private double mark4;
    private double mark5;
    public Results(string n, double m1, double m2, double m3, double m4, double m5)
    {
        name = n;
        mark1 = m1;
        mark2 = m2;
        mark3 = m3;
        mark4 = m4;
        mark5 = m5;
    }
    public void display()
    {
        Console.Write("\n{0, -18}", $"{name}");
        Console.Write("{0, -17}", $"{mark1}");
        Console.Write("{0, -17}", $"{mark2}");
        Console.Write("{0, -17}", $"{mark3}");
        Console.Write("{0, -17}", $"{mark4}");
        Console.Write("{0, -17}", $"{mark5}");
    }
    public double open_mark1 => mark1;
    public double open_mark2 => mark2;
    public double open_mark3 => mark3;
    public double open_mark4 => mark4;
    public double open_mark5 => mark5;
}
public class Program
{
    public static void Main(string[] args)
    {
        Results[] table = new Results[5]
        {
 new Results("первый", 1, 2,3,4,5),
 new Results("второй", 1, 2,3,4,5),
 new Results("третий", 1, 2,3,4,5),
 new Results("четвёртый",1, 2,3,4,5),
 new Results("пятый",1, 2,3,4,5)
        };
        double max;
        int index;
        Results switcher;
        for (int i = 0; i < table.Length - 1; i++)
        {
            bool flag = false;
            max = (table[i].open_mark1 + table[i].open_mark2 + table[i].open_mark3 + table[i].open_mark4 +
           table[i].open_mark5);
            index = i;
            for (int j = i + 1; j < table.Length; j++)
            {
                if ((table[j].open_mark1 + table[j].open_mark2 + table[j].open_mark3 + table[j].open_mark4 +
               table[j].open_mark5) > max)
                {
                    max = (table[j].open_mark1 + table[j].open_mark2 + table[j].open_mark3 + table[j].open_mark4 +
                   table[j].open_mark5);
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
        Console.WriteLine("Фамилия:\tОценка№1:\tОценка№2\tОценка№3\tОценка№4\tОценка№5");
        for (int i = 0; i < table.Length; i++)
        {
            table[i].display();
        }
    }
}*/
#endregion

#region 3_6
/*struct Answer
{
    private string animal;
    private string personality;
    private string thing;
    public Answer(string a, string p, string t)
    {
        animal = a;
        personality = p;
        thing = t;
    }
    public string open_animal => animal;
    public string open_personality => personality;
    public string open_thing => thing;
}
struct Static
{
    private string answer;
    private double count;
    public Static(string a, double c1)
    {
        answer = a;
        count = c1;
    }
    public void display()
    {
        Console.Write("\n{0, -40}", $"{answer}");
        Console.Write("{0, -40}", $"{count}");
    }
    public string open_answer => answer;
    public double open_count => count;
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите количество опрошенных: ");
        int count = int.Parse(Console.ReadLine());
        Answer[] table = new Answer[count];
        Static[] animal = new Static[count];
        Static[] personality = new Static[count];
        Static[] thing = new Static[count];
        string a, p, t;
        string[] answer_animal = new string[count];
        string[] answer_personality = new string[count];
        string[] answer_thing = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\n{0:d} опрошенный. (Вводите информацию с одним регистром)", i + 1);
            Console.WriteLine(" - Какое животное Вы связываете с Японией и японцами?");
            a = Console.ReadLine();
            Console.WriteLine(" - Какая черта характера присуща японцам больше всего?");
            p = Console.ReadLine();
            Console.WriteLine(" - Какой неодушевленный предмет или понятие Вы связываете с Японией?");
            t = Console.ReadLine();
            table[i] = new Answer(a, p, t);
        }
        for (int i = 0; i < count; i++)
        {
            a = table[i].open_animal;
            double k = 0;
            for (int j = 0; j < count; j++)
            {
                if (a == table[j].open_animal)
                {
                    k++;
                }
                animal[i] = new Static(a, 100 * k / count);
            }
            p = table[i].open_personality;
            k = 0;
            for (int j = 0; j < count; j++)
            {
                if (p == table[j].open_personality)
                {
                    k++;
                }
                personality[i] = new Static(p, 100 * k / count);
            }

            t = table[i].open_thing;
            k = 0;
            for (int j = 0; j < count; j++)
            {
                if (t == table[j].open_thing)
                {
                    k++;
                }
                thing[i] = new Static(t, 100 * k / count);
            }
        }
        double max;
        int index;
        Static switcher;
        Static[] gar = animal;
        for (int l = 0; l < 3; l++)
        {
            if (l == 0) gar = animal;
            if (l == 1) gar = personality;
            if (l == 2) gar = thing;

            for (int i = 0; i < gar.Length - 1; i++)
            {
                bool flag = false;
                max = gar[i].open_count;
                index = i;

                for (int j = i + 1; j < gar.Length; j++)
                {
                    if (gar[j].open_count > max)
                    {
                        max = gar[j].open_count;
                        index = j;
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    switcher = gar[index];
                    gar[index] = gar[i];
                    gar[i] = switcher;
                    flag = false;
                }
            }
            if (l == 0) animal = gar;
            if (l == 1) personality = gar;
            if (l == 2) thing = gar;
        }
        string[] gar2 = answer_animal;
        gar = animal;
        for (int l = 0; l < 3; l++)
        {
            Console.Write("\n\nВопрос №{0:d}\nНаиболее частный ответы:\tДолю встречи, %", l + 1);
            if (l == 1)
            {
                gar = personality;
                gar2 = answer_personality;
            }
            if (l == 2)
            {
                gar = thing;
                gar2 = answer_thing;
            }
            int k = 0;
            for (int i=0; i<gar.Length;i++)
            {
                if (k == 5) break;
                if ((i >= 1) && (gar2[i - 1] != gar[i].open_answer)) 
                {
                    gar[i].display();
                    k++;
                }
                else if (i < 1)
                {
                    gar[i].display();
                    k++;
                }
                gar2[i] = gar[i].open_answer;
            }
        }
    }
}*/
#endregion

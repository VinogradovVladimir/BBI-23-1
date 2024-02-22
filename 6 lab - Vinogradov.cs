using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
    public double open_result => (result1 + result2);
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
            max = (table[i].open_result);
            index = i;
            for (int j = i + 1; j < table.Length; j++)
            {
                if ((table[j].open_result) > max)
                {
                    max = (table[j].open_result);
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
        var sort = new Program();
        table=sort.Sort(table);
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
    private double[] mark;
    public Results(string n, double [] m)
    {
        name = n;
        mark = m;
    }
    public void display()
    {
        Console.Write("\n{0, -18}", $"{name}");

        for (int i=0; i<mark.Length;i++) Console.Write("{0, -17}", $"{mark[i]}");
    }
    public double[] open_mark => mark;
    public double Sum(double[] m)
    {
        double sum = 0;
        for (int i = 0; i < m.Length; i++) sum += m[i];
        return sum;
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
            var m = new Results();
            max = m.Sum(table[i].open_mark);
            index = i;
            for (int j = i + 1; j < table.Length; j++)
            {
                if (m.Sum(table[j].open_mark) > max)
                {
                    max = m.Sum(table[j].open_mark);
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
         new Results("первый", [1, 2,3,4,1]),
         new Results("второй", [1, 2,3,4,2]),
         new Results("третий", [1, 2,3,4,3]),
         new Results("четвёртый",[1, 2,3,4,499]),
         new Results("пятый",[1, 2,3,4,5])
        };
        var z = new Program();
        z.Sort(table);
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
    private Static[] Sort(Static[] gar)
    {
        double max;
        int index;
        Static switcher;
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
        return gar;
    } 
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
                if (a == table[j].open_animal) k++;
                animal[i] = new Static(a, 100 * k / count);
            }
            p = table[i].open_personality;
            k = 0;
            for (int j = 0; j < count; j++)
            {
                if (p == table[j].open_personality) k++;
                personality[i] = new Static(p, 100 * k / count);
            }

            t = table[i].open_thing;
            k = 0;
            for (int j = 0; j < count; j++)
            {
                if (t == table[j].open_thing) k++;
                thing[i] = new Static(t, 100 * k / count);
            }
        }
        var sort = new Program();
        animal = sort.Sort(animal);
        personality = sort.Sort(personality);
        thing = sort.Sort(thing);

        string[] gar2 = answer_animal;
        Static[] gar = animal;
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
            for (int i = 0; i < gar.Length; i++)
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

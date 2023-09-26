using System;
#region 1_1
/*int s = 0;
for (int i = 2; i <= 35; i +=  3)
{
    s += i;
}
Console.WriteLine(s);*/
#endregion

#region 1_2
/*double s = 0;
double g;
double c;
for (int i = 1; i <= 10; i++)
{
    c = 1;
    g = c / i;
    s = s + g;
    Console.WriteLine(g);
}
Console.WriteLine(s);
*/
#endregion

#region 1_3
/*double s = 0;
double g;
double c;
for (int i = 2; i <= 113; i += 2)
{
    c = i;
    g = c + 1;
    s += c / g;
}
Console.WriteLine(s);*/
#endregion

#region 1_4
/*double s = 0;
double x = 2;
for (int i = 1; i <= 9; i++)
{
    s += Math.Cos(x * i) / Math.Pow(x, i - 1);
    Console.WriteLine(Math.Pow(x, i - 1));
}
Console.WriteLine(s);*/
#endregion

#region 1_5
int p = 3;
int s = 0;
int h = 0
for (int i; i <= 9; int++)
{
    s += Math.Pow(p + h, 2);
}
Console.WriteLine(s);
#endregion
#region 1_1
/*int s = 0;
for (int i = 2; i <= 35; i += 3)
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
for (int i = 0; i <= 8; i++)
{
    s += Math.Cos(x * (i+1)) / x * i;
}
Console.WriteLine(s);*/
#endregion

#region 1_5
/*int p = 3;
double s = 0;
int h = 0;
for (int i = 0; i <= 9; i++)
{
    s += (p + h)*(p+h);
    h += 10;
}
Console.WriteLine(s);*/
#endregion

#region 1_6
/*double Xn = -4;
double Xk = 4;
double h = 0.5;
double n;
double x;
double y;
n = (Xk - Xn) / h + 1;
x = Xn;
for (int i = 1; i <= n; i++)
{
 y = 0.5 * (x * x) - 7 * x;
 Console.WriteLine("x={0:f3} y ={1:f3}", x, y);
 x += h;
}*/
#endregion
#region 1_7
/*int s=1;
for (int i = 2; i <= 6; i++)
{
 s *= i;
}
Console.WriteLine(s);*/
#endregion
#region 1_8
/*int s = 0;
int b = 1;
for (int i = 1; i <= 6; i++)
{
 b = b * i;
 s += b;
}
Console.WriteLine(s);*/
#endregion
#region 1_9
/*double s = 0;
int b = 1;
int a5 = 5;
int a1 = -1;
for (int i = 1; i <= 6; i++)
{
    b = b * i;
    s += a1 * a5 / b;
    a1 *= a1;
    a5 *= a5;
}
Console.WriteLine(s);*/
#endregion
#region 1_10
/*int x = 3;
int s = 1;
for (int i = 1; i <= 7; i++)
{
 s *= x;
}
Console.WriteLine(s);*/
#endregion
#region 1_11 a)
/*for (double i = 1; i <= 6; i++)
{
 Console.Write("{0,1} ", i);
}*/
#endregion
#region 1_11 б)
/*for (double i = 1; i <= 6; i++)
{
 Console.Write("{0,1} ", 5);
}*/
#endregion
#region 1_12
/*double x = double.Parse(Console.ReadLine());
double s = 1;
for (int i = 0; i <= 10; i++)
{
    s += 1 / x;
    x *= x;
}
Console.WriteLine(s);*/
#endregion
#region 1_13
/*double x0 = -1.5;
double x1 = 1.5;
double h = 0.1;
double x=-1.5;
double y;
for (int i = 1; i <= ((x1 - x0) / h + 1); i++)
{
 y = -1;
 if (x <= -1)
 {
 y = 1;
 }
 if (x > -1 & x <= 1)
 {
 y = -x;
 }
 Console.WriteLine("x={0:f3} y ={1:f3}", x, y);
 x += h;
}*/
#endregion
#region 1_14
/*Console.WriteLine(1);
Console.WriteLine(1);
int x1 = 1;
int x2 = 1;
int x3 = 0;
for (int i = 1; i <= 6; i++)
{
 Console.WriteLine(x1 + x2);
 x3 = x2;
 x2 = x1 + x2;
 x1 = x3;
}*/
#endregion
#region 1_15
/*double x1 = 1;
double x2 = 1;
double x3 = 0;
double s = 0;
for (int i = 1; i <= 4; i++)
{
 s=((x1 + x2)/x2);
 x3 = x2;
 x2 = x1 + x2;
 x1 = x3;
}
Console.WriteLine(s);*/
#endregion
#region 2_1
/*double s = 0;
int x = 401;
int n = 1;
while ((Math.Cos(n * x) / n*n) > 0.0001)
{
    s += (Math.Cos(n * x) / n*n);
    n++;
}
Console.WriteLine(s);*/
#endregion
#region 2_2
/*int p = 1;
int n = 1;
while (p < 30000)
{
 p = p * n;
 n += 3;
}
Console.WriteLine(n - 3);*/
#endregion
#region 2_3
/*int n = 0;
int s = 0;
int p = 10000;
int a = 10;
int h = 9;
while (s < p)
{
 s += (a + n * h);
 n++;
}
Console.WriteLine(n);*/
#endregion
#region 2_4
/*double s = 0;
double x = 0.5;
double e = 0.0001;

double s1 = 1;
while (s1 > e)
{
    s += s1;
    s1 *= (x * x);
}
Console.WriteLine(s);*/
#endregion
#region 2_5
/*double ost = 15;
double m = 9;
double cs = 0;
while (ost >= m)
{
 ost -= m;
 cs += 1;
}
Console.WriteLine("частное ={0,3}",cs);
Console.WriteLine("остаток ={0,3}",ost);*/
#endregion
#region 2_6
//не нашёл 18 задачи 1 уровня, всего 15
#endregion
#region 2_7 a)
/*double dist = 10;
int day = 1;
double s = 0;
while (day <= 7)
{
 s += dist;
 dist = dist * 1.1;
 //Console.WriteLine("{0,4} {1,4}", day, s);
 day++;
}
Console.WriteLine(s);*/
#endregion
#region 2_7 б)
/*double dist = 10;
int day = 1;
double s = 0;
while (s < 100)
{
 s += dist;
 dist = dist * 1.1;
 //Console.WriteLine("{0,4} {1,4}", day, s);
 day++;
}
Console.WriteLine(day-1);*/
#endregion
#region 2_7 в)
/*double dist = 10;
int day = 1;
double s = 0;
while (dist < 20)
{
 s += dist;
 dist = dist * 1.1;
 Console.WriteLine("{0,4} {1,4} {2,4}", day, s,dist);
 day++;
}
Console.WriteLine(day - 1);*/
#endregion
#region 2_8
/*int s = 10000;
int p = 8;
int x = 0;
while (s < 10000 * 2)
{
 s += (s * p) / 100;
 x += 1;
}
Console.WriteLine(x);*/
#endregion

#region 3_4
using System;
using System.Security.Cryptography;

double a = 0.1;
double b = 1;
double h = 0.1;
double sum = 0;
for (double x = a; x <= b; x += h)
{
    double i = 1;
    double fact = 1;
    double stepX2I = x;
    while (((2 * i + 1) * stepX2I / fact) > 0.0001)
    {
        sum += ((2 * i + 1) * stepX2I / fact);
        i++;
        fact *= i;
        stepX2I = stepX2I * stepX2I;
    }
    Console.WriteLine("функция Y в точке X = {1,1} равна {0,1}", (1 + 2 * x * x) * Math.Pow(Math.E, x * x), x);
}
Console.WriteLine("итоговая сумма = {0,1}", sum);
#endregion

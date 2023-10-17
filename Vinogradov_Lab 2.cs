using System;

#region 1_1
/*Console.Write("Введите координты X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координты Y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите радиус: ");
double r = Convert.ToDouble(Console.ReadLine());
if (Math.Abs(x * x + y * y - r * r) <= 1 / 1000)
{
    Console.WriteLine("Точка Лежит на окружности");
}
else
{
    Console.WriteLine("Точка Не лежит на окружности");
}*/
#endregion

#region 1_2
/*Console.Write("Введите координты X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координты Y: ");
double y = Convert.ToDouble(Console.ReadLine());
if (x < 0)
{
    if ((1 + x >= 0) & (y + Math.Abs(x) <= 1))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    if ((1 - x >= 0) & (y + Math.Abs(x) <= 1))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}*/
#endregion

#region 1_3
/*Console.Write("Введите значение a: ");
double a = Double.Parse(Console.ReadLine());
Console.Write("Введите значение b: ");
double b = Double.Parse(Console.ReadLine());
double C = a;
if (a > 0)
{
    if (b > a) C = b;
}
else
{
    if (b < a) C = b;
}
Console.WriteLine(C);*/
#endregion

#region 1_4
/*Console.Write("Введите значение a: ");
double a = Double.Parse(Console.ReadLine());
Console.Write("Введите значение b: ");
double b = Double.Parse(Console.ReadLine());
Console.Write("Введите значениe c: ");
double c = Double.Parse(Console.ReadLine());
double z = a;
if (a > b)
{
    z = b;
    if (c > z) z = c;
}
else
{
    if (c > z) z = c;
}
Console.WriteLine(" z= {0}", z);*/
#endregion

#region 1_5
/*Console.Write("Введите площадь круга: ");
double r = Double.Parse(Console.ReadLine());
Console.Write("Введите площадь квадрата: ");
double s = Double.Parse(Console.ReadLine());
double storona = Math.Sqrt(s);
double radius = Math.Sqrt(r / Math.PI);
if (radius >= storona * (Math.Sqrt(2)))
    Console.WriteLine("поместиться");
else Console.WriteLine("не поместиться");

//ответы 1)нет 2)нет*/
#endregion

#region 1_6
/*Console.Write("Введите площадь круга: ");
double r = Double.Parse(Console.ReadLine());
Console.Write("Введите площадь квадрата: ");
double s = Double.Parse(Console.ReadLine());
double storona = Math.Sqrt(s);
double radius = Math.Sqrt(r / Math.PI);
if (radius <= storona/2)
    Console.WriteLine("поместиться");
else Console.WriteLine("не поместиться");

//ответы 1)нет 2)нет 3)да*/
#endregion

#region 1_7
/*Console.Write("Введите значение x: ");
double x = Double.Parse(Console.ReadLine());
if ((x > 1) || (x < -1))
{
    Console.WriteLine("y = 1");
}
else
    Console.WriteLine("y = {0}", Math.Sqrt(x*x));*/
#endregion

#region 1_8
/*Console.Write("Введите значение x: ");
double x = Double.Parse(Console.ReadLine());
if ((x > 1) || (x < -1))
{
    Console.WriteLine("y = 0");
}
else
    Console.WriteLine("y = {0}", x*x-1);*/
#endregion

#region 1_9
/*Console.Write("Введите значение x: ");
double x = Double.Parse(Console.ReadLine());
if (x <= -1) 
    Console.WriteLine("y = 0");
else if ((x > -1) && (x <= 0)) 
    Console.WriteLine("y = {0}",x+1);
else 
    Console.WriteLine("y = 1");*/
#endregion

//сделал лишний 2_1
#region 2_1
/*Console.Write("Введите количество учеников: ");
double n = Double.Parse(Console.ReadLine());
double sum = 0;
for (int i=0; i<n; i++)
{
    Console.Write("Введите рост ученика №{0}: ",i+1);
    sum+=double.Parse(Console.ReadLine());
}
Console.WriteLine("Средний рост = {0}", sum / n);*/
#endregion

#region 2_2
/*Console.Write("Введите Количество точек: ");
double n = Double.Parse(Console.ReadLine());
Console.Write("Введите Радиус окружности: ");
double r = Double.Parse(Console.ReadLine());
Console.Write("Введите коорд. X центра окружности: ");
double x1 = Double.Parse(Console.ReadLine());
Console.Write("Введите коорд. Y центра окружности: ");
double y1 = Double.Parse(Console.ReadLine());
int count = 0;
double x, y;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите коодинату X {0} точки: ", i + 1);
    x=double.Parse(Console.ReadLine());
    Console.Write("Введите коодинату Y {0} точки: ", i + 1);
    y=double.Parse(Console.ReadLine());
    if (Math.Abs((x - x1) * (x - x1) + (y - y1) * (y - y1) - r * r) <= 1 / 1000)
        count += 1;
}
Console.WriteLine("Количество точек: {0}", count);*/
#endregion

#region 2_5
/*double n = 30;
Console.Write("Введите норматив: ");
double result=Double.Parse(Console.ReadLine());
double count = 0, x;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите результат спортсмена №{0}: ", i+1);
    x = double.Parse(Console.ReadLine());
    if (x>=result)
        count += 1;
}
Console.WriteLine("Спортсменов выполнивших норматив: {0}", count);*/
#endregion

#region 2_8
Console.Write("Введите Количество точек: ");
double n = Double.Parse(Console.ReadLine());
int count = 0;
double x, y;
double rast = 9999999;
double nomer=0;
for (double i = 0; i < n; i++)
{
    Console.Write("Введите коодинату X {0} точки: ", i + 1);
    x = double.Parse(Console.ReadLine());
    Console.Write("Введите коодинату Y {0} точки: ", i + 1);
    y = double.Parse(Console.ReadLine());
    if (rast > (Math.Sqrt(x * x + y * y)))
    {
        nomer = i+1;
        rast = (Math.Sqrt(x * x + y * y));
    }
}
Console.WriteLine("Ближайшая точка №{0}, расстояние = {1}", nomer, rast);
#endregion
// lvl 1: 1,5,9,13,17,21,25,29,33
// lvl 2: 1,5,9
// lvl 3: 1,5,9

#region 1_1
/*int sum = 0;
int[,] a = new int[,] { { 1, 2, 3, 4, 5 }, { 2, 2, 3, 4, 5 }, { 3, 2, 3, 4, 5 }, { 4, 2, 3, 4, 5 }, { 5, 2, 3, 4, 5 }, { 6, 2, 3, 4, 5 }, { 7, 2, 3, 4, 5 } };
for (int i=0; i < 7; i++)
{
    for (int j=0; j < 5; j++)
    {
        sum += a[i, j];
    }
}
Console.WriteLine(sum);*/
#endregion

#region 1_5
/*int[,] a = new int[,] { { 1, 2, 3, 4 }, { 2, 2, 3, 1 }, { 3, 2, 3, 4 }, { 4, 2, 1, 4 }, { 5, 2, 3, 3} };
int index = 0, b = a[0, 3], n = 4;
for (int i = 0; i < 4; i++)
{
    if (a[i, n - 1] <= b)
    {
        b = a[i, n - 1];
        index = i;
    }
}
Console.WriteLine("индекс - [{0:d},{1:d}] ", index, n - 1);
Console.WriteLine("значение - {0:d} ", b);*/
#endregion

#region 1_9
/*int max = 0, index = 0, z = 0;
int[,] a = new int[,] { { 1, 2, 3, 4, 5, 6, 7 }, { 2, 2, 3, 4, 5, 8, 7 }, { 3, 2, 3, 4, 5, 6, 7 }, { 4, 2, 3, 4, 5, 6, 7 }, { 5, 2, 3, 4, 5, 6, 7 } };
for (int i = 0; i < 5; i++)
{
    max = a[i, 0];
    index = 0;
    z = 0;
    for (int j = 0; j < 7; j++)
    {
        if (max < a[i, j])
        {
            index = j;
            max = a[i, j];
        }
    }
    z = a[i, 0];
    a[i, 0] = max;
    a[i, index] = z;
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++)
    {
        Console.Write("{0:d} ", a[i, j]);
    }
}*/
#endregion

#region 1_13
/*int[,] a = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 99, 9, 15 }, { 16, 17, 18, 44, 20 }, { 21, 22, 23, 24, 25 } };
int max = a[0, 0], index = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
for (int i = 0; i < 5; i++)
{
    if (max < a[i, i])
    {
        max = a[i, i];
        index = i;
    }
}
if (index != 3)
{
    int g = 0;
    for (int i = 0; i < 5; i++)
    {
        g =a[i, 3];
        a[i, 3] = a[i, index];
        a[i, index] = g;
    }
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}*/
#endregion

#region 1_17
/*Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
int[,] a = new int[n, m];
int[] b = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите элементы {0:d} строки (через пробел): ", i + 1);
    string s = Console.ReadLine();
    string[] c = s.Split(' ');
    for (int j = 0; j < m; j++)
    {
        a[i, j] = int.Parse(c[j]);
    }
    int min = a[i, 0], index = 0;
    for (int j = 0; j < m; j++)
    {
        if (a[i, j] < min)
        {
            min = a[i, j];
            index = j;
        }
    }
    b[i] = index;
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    for (int j = 0; j < m; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
//for(int i = 0; i < n; i++) Console.Write("{0:d} ", b[i]);
for (int i = 0; i < n; i++)
{
    int nac = a[i, 0],k;
    if (b[i] != 0)
    {
        a[i, 0] = a[i,b[i]];
        for (int j=1; j<= b[i]; j++)
        {
            k = a[i, j];
            a[i, j] = nac;
            nac = k;
        }
    }
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    for (int j = 0; j < m; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}*/
#endregion

#region 1_21
/*int n = 5, m = 7;
int[,] a = new int[n, m];
for (int i = 0; i < 6; i++)
{
    Console.Write("Введите 5 значений {0:d} столбца (через пробел): ", i + 1);
    string s = Console.ReadLine();
    string[] c = s.Split(' ');
    for (int j=0; j<n; j++)
    {
        a[j, i] = int.Parse(c[j]);
    }
}
for (int i=0; i < n; i++)
{
    Console.WriteLine();
    for (int j=0; j<m; j++)  Console.Write("\t{0:d} ", a[i, j]);
}
int max, index;
Console.WriteLine();
for (int i=0; i < 5; i++)
{
    max = a[i, 0];
    index = 0;
    for (int j=0; j < m; j++)
    {
        if (a[i, j] > max)
        {
            max = a[i, j];
            index = j;
        }
    }
    a[i, 6] = a[i,5];
    a[i, 5] = max;
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    for (int j = 0; j < m; j++) Console.Write("\t{0:d} ", a[i, j]);
}*/
#endregion

#region 1_25
/*int [,] a = new int[6, 5] { { -1, -2, -3, 4, 5 }, { 1, 2,-3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, -3, -4, 5 }, { 1, 2, -3, 4, 5 }, { 1, 2, 3, 4, -5 } };
for (int i = 0; i < 6; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++) Console.Write("{0:d}\t", a[i, j]);
}
int min = 99, max = -90, indexMin=0, indexMax=0,k;
for (int i = 0;i < 6; i++)
{
    k = 0;
    for (int j = 0;j < 5; j++)
    {
        if (a[i, j] < 0) k++;
    }
    if (k > max)
    {
        max = k;
        indexMax = i;
    }
    if (k < min)
    {
        min = k;
        indexMin = i;
    }
}
Console.WriteLine("\n{0}",indexMin);
Console.WriteLine(indexMax);
if (max != min)
{
    for (int j = 0; j < 5; j++)
    {
        k = a[indexMin, j];
        a[indexMin, j] = a[indexMax, j];
        a[indexMax, j] = k;
    }
}
for (int i = 0; i < 6; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++) Console.Write("{0:d}\t", a[i, j]);
}*/
#endregion

#region 1_29
/*int[,] a = new int[5, 7] { { 1, 2, 3, 4, 5, 6, 7 }, { 2, 2,1, 2, 2, 2, 2 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 } };
int min = Math.Abs(a[1, 0]), index = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++) Console.Write("{0:d}\t", a[i, j]);
}
Console.WriteLine();
for (int j=0; j<7; j++)
{
    if (Math.Abs(a[1, j]) < min)
    {
        min = Math.Abs(a[1, j]);
        index = j;
    }
}
int k = 0;
for (int i=0; i<5; i++) 
{
    for (int j=index+1; j<6; j++)
    {
        a[i, j] = a[i,j+1];
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 6; j++) Console.Write("{0:d}\t", a[i, j]);
}
Console.WriteLine();*/
#endregion

#region 1_33
/*int[,] a = new int[5, 7] { { -1, -2, -3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, -6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, -2, 3, -4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, -7 } };
int[] b = new int[35];
int k = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++) Console.Write("{0:d}\t", a[i, j]);
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (a[i, j] < 0)
        {
            b[k] = a[i, j];
            k++;
        }
    }
}
Console.WriteLine();
for (int i = 0; i < k; i++)
{
    Console.Write("{0:d} ", b[i]);
}*/
#endregion

// lvl 2: 1,5,9

#region 2_1
/*int[,] a = new int[5, 7] { { 1, 2, 3, 4, 5, 6, 99 }, { 99, 2, 3, 4, 5, 6, 7 }, { 1, 99, 3, 4, 5, 6, 7 }, { 4, 99, 3, 4, 5, 6, 7 }, { 1, 2, 5, 99, 5, 6, 7 } };
int max, index;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
for (int i = 0; i < 5; i++)
{
    max = a[i, 0];
    index = 0;
    for (int j = 0; j < 7; j++)
    {
        if (a[i, j] > max)
        {
            max = a[i, j];
            index = j;
        }
    }
    if (index == 0) a[i, 1] = a[i, 1] * 2;
    else if (index == 6) a[i, 5] = a[i, 5] * 2;
    else
    {
        if (a[i, index - 1] > a[i, index + 1]) a[i, index + 1] = a[i, index + 1] * 2;
        else if (a[i, index - 1] < a[i, index + 1]) a[i, index - 1] = a[i, index - 1] * 2;
    }
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}*/
#endregion

#region 2_5
/*int[,] a = new int[7, 5] { { 99, 2, 3, 4, 99 }, { 1, 99, 3, 4, 5 }, { 1, 2, 99, 4, 5 }, { 1, 2, 3, 99, 5 }, { 1, 2, 5, 3, 99 }, { 99, 2, 5, 99, 99 }, { 1, 2, 5, 3, 99 } };
int max, index;
for (int i = 0; i < 7; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
for (int stolb=0; stolb < 5; stolb++)
{
    max = a[0, stolb];
    index = 0;
    for (int str=0; str < 7; str++)
    {
        if (a[str, stolb] > max)
        {
            max= a[str, stolb];
            index = stolb;
        }
    }
    if (max < (a[0, stolb] + a[6, stolb]) / 2)
    {
        for (int str=0; str <7; str++)
        {
            if (a[str, stolb] == max) a[str, stolb] = (a[0, stolb] + a[6, stolb])/2; 
        }
    }
    else
    {
        for (int str = 0; str < 7; str++)
        {
            if (a[str, stolb] == max) a[str, stolb] = (str + 1);
        }
    }

}
Console.WriteLine();
for (int i = 0; i < 7; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
Console.WriteLine();*/
#endregion
//максимальный элемент не может быть меньше полусуммы
//только если он максимальный среди элементов, не учитывающий либо 1, либо последний элемент столбца


#region 2_9
/*int[,] a = new int[6, 7] { {1,2,3,4,5,6,7 }, { 1, 2, 3, 4, 5, 99, 7 }, { 1, 2, 3, 99, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 99 } };
int[] b = new int[7];
int k;
for (int i = 0; i < 6; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 7; j++)
    {
        b[j] = a[i, j];
    }
    k = 0;
    for (int j=6; j>=0; j--)
    {
        a[i, j] = b[k];
        k++;
    }
}
Console.WriteLine();
for (int i = 0; i < 6; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
Console.WriteLine();*/
#endregion

#region 3_1
/*int[,] a = new int[7, 6] { { 9, 9, 9, 2, 9, 0 }, { 8, 8, 4, 8, 4, 0 }, { 4, 5, 3, 6, 7, 0 }, { 5, 5, 6, 7, 8, 0 }, { 1, 2, 4, 5, 6, 0 }, { 17, 87, 85, 86, 87, 0 }, { 7, 8, 9, 0, 10, 0 } };
int[] b = new int[7];
int min, k = 0, max, index = 0;
for (int i = 0; i < 7; i++)
{
    min = a[i, 0];
    for (int j = 0; j < 5; j++)
    {
        if (a[i, j] < min) min = a[i, j];
    }
    b[i] = min;
    a[i, 5] = min;
}
for (int i = 0; i < 7; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
Console.WriteLine();
for (int i = 0; i < 7; i++)
{
    max = b[i];
    index = i;
    for (int j = i + 1; j < 7; j++)
    {
        if (b[j] > max)
        {
            max = b[j];
            index = j;
        }
    }
    k = b[i];
    b[i] = max;
    b[index] = k;
}
Console.WriteLine();
int elem = 0;
for (int i = 0; i < 7; i++)
{
    elem = b[i];
    index = 0;
    for (int j = 0; j < 7; j++)
    {
        if (a[j, 5] == elem)
        {
            index = j;
        }
    }
    for (int i2 = 0; i2 < 6; i2++)
    {
        k = a[i, i2];
        a[i, i2] = a[index, i2];
        a[index, i2] = k;
    }
}
Console.WriteLine();
for (int i = 0; i < 7; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}*/
#endregion

#region 3_5
Console.Write("Введите параметр N, для матрицы NxN: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите параметр K, 1<=k<=n: ");
int k = int.Parse(Console.ReadLine());
if (n < 1) Console.WriteLine("Пустая матрица");
else
{
    int[,] a = new int[n, n];
    Random rand = new Random();
    int max = a[0, 0], Str = 0, Stolb = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = rand.Next(-99, 99);
        }
    }
    Console.WriteLine();
    int x1 = rand.Next(0, n);
    int y1 = rand.Next(0, n);
    a[y1, x1] = rand.Next(1000, 10000);
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0:d}\t", a[i, j]);
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (Math.Abs(a[i, j]) > max)
            {
                max = Math.Abs(a[i, j]);
                Str = i;
                Stolb = j;
            }
        }
    }
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        x1 = a[k - 1, i];
        a[k - 1, i] = a[Str, i];
        a[Str, i] = x1;
    }
    for (int i = 0; i < n; i++)
    {
        x1 = a[i, k - 1];
        a[i, k - 1] = a[i, Stolb];
        a[i, Stolb] = x1;
    }
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0:d}\t", a[i, j]);
        }
    }
}
#endregion

#region 3_9
/*int[,] a = new int[6, 7] { { -15, 11, 9, -16, 9, -13, -10 }, { -8, -8, 4, 8, 4, 10, 43 }, { -4, 54, -3, -63, 7, -11, 2 }, { -4, -5, -7, -8, -4, -6, 0 }, { -4, 5, 7, 8, 4, 6, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
int[] b = new int[7];
int min, k = 0, index = 0;
for (int i = 0; i < 7; i++)
{
    k = 0;
    for (int j = 0; j < 5; j++)
    {
        if (a[j, i] < 0) k++;
    }
    a[5, i] = k;
    b[i] = a[5, i];
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}
Console.WriteLine();
for (int i = 0; i < 7; i++)
{
    min = b[i];
    index = i;
    for (int j = i + 1; j < 7; j++)
    {
        if (b[j] < min)
        {
            min = b[j];
            index = j;
        }
    }
    k = b[i];
    b[i] = min;
    b[index] = k;
}
for (int i = 0; i < 7; i++)
{
    index = 0;
    for (int j = 0; j < 7; j++)
    {
        if (a[5, j] == b[i])
        {
            index = j;
        }
    }
    for (int i2 = 0; i2 < 6; i2++)
    {
        k = a[i2, i];
        a[i2, i] = a[i2, index];
        a[i2, index] = k;
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 7; j++)
    {
        Console.Write("{0:d}\t", a[i, j]);
    }
}*/
#endregion
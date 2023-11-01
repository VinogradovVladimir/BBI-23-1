#region 1_1
/*int n = 6;
double sum = 0;
double [] a = new double [] {1,2,3,4,5,6};
for (int i=0; i<n; i++)
{
    sum += a[i];
}

for (int i=0;i<n; i++)
{
    a[i] = sum / a[i];
    Console.Write("{0:f1} ", a[i]);
}*/
#endregion

#region 1_2
/*int n = 8;
double sum = 0, count=0;
double[] a = new double[] { -1, -2, -3, -4, 5, 6, 7, 8};
for (int i = 0; i < n; i++)
{
    if (a[i] > 0)
    {
        sum += a[i];
        count++;
    }
}

for (int i = 0; i < n; i++)
{

    if (a[i] > 0)
    {
        a[i] = sum / count;
    }
    Console.Write("{0:f1} ", a[i]);
}*/
#endregion

#region 1_3
/*int n = 4;
double[] a1 = new double[] { 10, 10, 10, 10 };
double[] a2 = new double[] { 1, 2, 3, 4 };
double[] sum = new double[4];
for (int i = 0; i < n; i++)
{
    sum[i]=(a1[i] + a2[i]);
}
Console.Write("сумма: ");
for (int i = 0; i < n; i++)
{
    Console.Write("{0:f1} ", sum[i]);
}
Console.WriteLine("");
for (int i = 0; i < n; i++)
{
    sum[i] = (a1[i] - a2[i]);
}
Console.Write("разность: ");
for (int i = 0; i < n; i++)
{
    Console.Write("{0:f1} ", sum[i]);
}*/
#endregion

#region 1_4
/*double sum = 0, n=5;
double[] a = new double[] { 1, 2, 3, 4, 5 };
for (int i = 0; i < n; i++)
{
    sum+= a[i];
}
for (int i = 0;i < n; i++)
{
    a[i] = (a[i] - sum / n);
}
for (int i = 0; i<n ; i++) Console.Write("{0:f1} ", a[i]);*/
#endregion

#region 1_5
/*double sk = 0, n = 4;
double[] a1 = new double[] { 1, 2, 3, 4 };
double[] a2 = new double[] { 5, 6, 7, 8 };
for (int i = 0; i < n; i++)
{
    sk += a1[i] * a2[i];
}
Console.WriteLine(sk);*/
#endregion

#region 1_6
/*double R = 0, n = 5;
double[] a1 = new double[] { 1, 2, 3, 4, 5 };
for (int i = 0; i < n; i++)
{
    R += a1[i] * a1[i];
}
Console.WriteLine(Math.Sqrt(R));*/
#endregion

#region 1_7
/*double n = 7, sum=0;
double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7 };
for (int i = 0; i < n; i++)
{
    sum+= a[i];
}
for (int i = 0; i < n; i++)
{
    if (a[i] > (sum / n))
        a[i] = 0;
}
for (int i = 0; i < n; i++)
{
    Console.Write("{0:f1} ", a[i]);
}*/
#endregion

#region 1_8
/*double n = 6, sum = 0;
double[] a = new double[] { 1, 2, 3, 4, -5, 6};
for (int i = 0; i < n; i++)
{
   if (a[i]>0) sum ++;
}
Console.WriteLine(sum);*/
#endregion

#region 1_9
/*double n = 8, sum = 0, sc=0;
double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8 };
for (int i = 0; i < n; i++)
{
    sum += a[i];
}
for (int i = 0; i < n; i++)
{
    if (a[i] > (sum / n))
        sc++;
}
Console.WriteLine(sc);*/
#endregion

#region 1_9
/*double n = 10, sc=0;
double P = 4;
double Q = 9;
double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8,9,10 };
for (int i = 0; i < n; i++)
{
    if ((a[i]>P) && (a[i]<Q)) sc ++;
}

Console.WriteLine(sc);*/
#endregion

#region 1_11
/*double n = 10;
int dlinn = 0;
double[] a1 = new double[] { -1, 2, 3, 4, -5, 6, 7, 8, -9, 10 };
double[] a2= new double[10];
for (int i = 0; i < n; i++)
{
    if (a1[i] > 0)
    {
        a2[dlinn] = a1[i];
        dlinn++;
    }
}
for (int i = 0; i < dlinn; i++)
{
    Console.Write("{0:f1} ", a2[i]);
}*/
#endregion

#region 1_12
/*int n = 8;
double[] a = new double[] { -1, 2, 3, 4, -5, 6, -7, -8};
for (int i = n-1; i > 0; i--)
{
    if (a[i] < 0)
    {
        Console.WriteLine("значение: {0:f1} ; индекс: {1:f1}", a[i], i);
        break;
    }
}*/
#endregion

#region 1_13
/*int ch_a1 = 0, ch_a2 = 0;
double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 99, 9, 10 };
double[] a1 = new double[5];
double[] a2 = new double[5];
for (int i = 0; i < 10; i++)
{
    if (i%2==0)
    {
        a1[ch_a1] = a[i];
        ch_a1++;
    }
    else
    {
        a2[ch_a2] = a[i];
        ch_a2++;
    }
}
Console.Write("Чётные индексы: ");
for (int i = 0; i < 5; i++)
{
    Console.Write("{0:f1} ", a1[i]);
}
Console.WriteLine("");
Console.Write("Нечётные индексы: ");
for (int i = 0; i < 5; i++)
{
    Console.Write("{0:f1} ", a2[i]);
}*/
#endregion

#region 1_14
/*int n = 11;
double sum = 0;
double[] a = new double[] { 1, 2, 3, 4, 5, 6, -7, -8,9,10,11 };
for (int i =0 ; i < n; i++)
{
    if (a[i] < 0)
    {
        break;
    }
    sum += a[i]*a[i];
}
Console.WriteLine(sum);*/
#endregion

#region 1_15
/*int n = 10;
double[] x = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
double[] y = new double[10];
for (int i = 0; i < n; i++)
{
    y[i] = Math.Log2(x[i]) * 0.5;
}
Console.WriteLine("Знач. X     Знач. Y");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0:f4}     {1:f4}", x[i], y[i]);
}*/
#endregion

#region 2_1 
/*double[] a = new double[] { 99, 2, 3, 4, 5, 6, 7, 8, 9 };
double a1 = a[0];
int i1 = 0, i = 0;
foreach (double x in a)
{
    if (x < a1)
    {
        a1 = x;
        i1 = i;
    }
    i++;
}
Console.WriteLine("Минимальный элемент {0:f}", a[i1]);
Console.WriteLine("Итоговый массив:");
a[i1] = a1 * 2;
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}*/
#endregion

#region 2_2
/*double[] a = new double[] { 98, 2, 3, 4, 99, 5, 6, 7, 8 };
double amax = a[0], indexMax = 0, sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if (amax < a[i])
    {
        amax = a[i];
        indexMax = i;
    }
}
for (int i = 0; i < indexMax; i++)
{
    sum += a[i];
}
Console.WriteLine("Сумма = {0:f}", sum);*/
#endregion

#region 2_3
/*double[] a = new double[] { 98, 2, 3, 4, 0, 5, 6, 7, 8 };
double aMin = a[0], indexMin = 0;
for (int i = 0; i < a.Length; i++)
{
    if (aMin > a[i])
    {
        aMin = a[i];
        indexMin = i;
    }
}
Console.WriteLine("Изначальный массив:");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}
Console.WriteLine("");
Console.WriteLine("Итоговый массив:");
for (int q = 0; q < a.Length; q++)
{
    if (q < indexMin)
    {
        a[q] = a[q] * 2;
    }
    Console.Write("{0:f} ", a[q]);
}*/
#endregion

#region 2_4
/*double[] a = new double[] { 9, 2, 3, 99, 0, 5, 6, 7, 8 };
double aMax = a[0], indexMax = 0, sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if (aMax < a[i])
    {
        aMax = a[i];
        indexMax = i;
    }
    sum += a[i];
}
double SR=sum/a.Length;
Console.WriteLine("Изначальный массив:");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}
Console.WriteLine("");
Console.WriteLine("Итоговый массив:");
for (int q = 0; q < a.Length; q++)
{
    if (q > indexMax)
    {
        a[q] = SR;
    }
    Console.Write("{0:f} ", a[q]);
}*/
#endregion

#region 2_5
/*double[] a = new double[] { 9, -999, 3, -1, -2, 5, -100, 400, 8 };
double aMax = a[0], indexMax = 0;
double aMin = a[0], indexMin = 0;
for (int i = 0; i < a.Length; i++)
{
    if (aMax < a[i])
    {
        aMax = a[i];
        indexMax = i;
    }
    if (aMin > a[i])
    {
        aMin = a[i];
        indexMin = i;
    }
}
Console.WriteLine("Изначальный массив:");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}
Console.WriteLine("");
Console.WriteLine("Итоговый массив: ");
for (int q = 0; q < a.Length; q++)
{
    if (((q>indexMax && q<indexMin) || (q < indexMax && q > indexMin)) && (a[q]<0))
    {
        Console.Write("{0:f} ", a[q]);
    }
}*/
#endregion

#region 2_6
/*double[] a = new double[] {90, 3, 6, 7, 100, 40, 8 };
double p = 666, sum=0, minRast=998999, index=0;
for (int i = 0; i < a.Length; i++)
{
    sum += a[i];
}
double SR = sum / a.Length;
for (int i=0; i < a.Length; i++)
{
    if (Math.Abs(a[i] - SR) < minRast)
    {
        minRast = Math.Abs(a[i]-SR);
        index = i;
    }
}
Console.WriteLine("Изначальный массив:");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}
Console.WriteLine("");
Console.WriteLine("Среднее {0:f}",SR);
Console.WriteLine("Итоговый массив: ");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
    if (q == index)
    {
        Console.Write("{0:f} ", p);
    }
}*/
#endregion

#region 2_7
/*double[] a = new double[] { 7, 3, 6, 7, 17, 17, 9 };
double Max = a[0];
int index = 0;
for (int i = 1; i < a.Length; i++)
{
    if (Max <= a[i])
    {
        Max = a[i];
        index = i;
    }
}
if (index < a.Length - 1)
    a[(index + 1)] = a[(index + 1)] * 2;
Console.WriteLine("Итоговый массив: ");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}*/
#endregion

#region 2_8
/*double[] a = new double[] { 7, 3, 6, 88, 17, 4, 9 };
double Max = a[0], Min=a[0];
int indexMax = 0, indexMin=(a.Length-1);
for (int i = 1; i < a.Length; i++)
{
    if (Max <= a[i])
    {
        Max = a[i];
        indexMax = i;
    }
}
Min = Max;
for (int i = indexMax; i < a.Length; i++)
{
    if (Min >= a[i])
    {
        Min = a[i];
        indexMin = i;
    }
}
a[indexMax] = Min;
a[indexMin] = Max;
Console.WriteLine("Итоговый массив: ");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}*/
#endregion

#region 2_9
/*double[] a = new double[] { 9, 99, 2, -5, 10, -40, -8 };
double aMax = a[0], indexMax = 0;
double aMin = a[0], indexMin = 0;
double count = 0, sum = 0, sr=0;
for (int i = 0; i < a.Length; i++)
{
    if (aMax < a[i])
    {
        aMax = a[i];
        indexMax = i;
    }
    if (aMin > a[i])
    {
        aMin = a[i];
        indexMin = i;
    }
}
for (int q = 0; q < a.Length; q++)
{
    if (((q > indexMax && q < indexMin) || (q < indexMax && q > indexMin)))
    {
        count++;
        sum += a[q];
    }
}
sr = sum / count;
Console.WriteLine("Массив: ");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}
Console.WriteLine("");
Console.WriteLine("ответ: {0:f}",sr);*/
#endregion

#region 2_10
/*double[] a = new double[] { 1, 2, 3, 4, -5, 6 };
double min = a[0];
for (int i = 0; i < a.Length; i++)
{
    if ((a[i] < min) && (a[i] > 0))
    {
        min = a[i];
    }
}
Console.WriteLine("Изначальный массив: ");
for (int q = 0; q < a.Length; q++)
{
    Console.Write("{0:f} ", a[q]);
}
Console.WriteLine("");
Console.WriteLine("Итоговый массив: ");
for (int i = 0; i < a.Length; i++)
{
    if (a[i] != min) Console.Write("{0:f} ", a[i]);
}*/
#endregion

#region 2_11
/*Console.Write("Введите P: ");
double p = Double.Parse(Console.ReadLine());
double[] a = new double[] { -1, -2, 3, 4, -5, -6 };
double index = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0) index = i;
}
Console.WriteLine("Итоговый массив: ");
for (int i = 0;i < a.Length; i++)
{
    Console.Write("{0:f} ", a[i]);
    if (i == index) Console.Write("{0:f} ", p);
}*/
#endregion

#region 2_12
/*double[] a = new double[] { 1, -2, -3, 8, 6, 5 };
int indexMin = a.Length, indexMax = 0;
double Max = a[0], sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if ((a[i] < 0) && (indexMin > i))
    {
        indexMin = i;
    }
    if (a[i] > Max)
    {
        Max = a[i];
        indexMax = i;
    }
}
for (int i = indexMax+1; i < a.Length; i++)
{
    sum+= a[i];
}
for (int i = 0; i < a.Length; i++)
{
    if (i == indexMin)
    {
        Console.Write("{0:f} ", sum);
    }
    else Console.Write("{0:f} ", a[i]);
}*/
#endregion

#region 2_13
/*double[] a = new double[] { 1, -2, -3, 8, 6, 5,799 };
double max = a[0];
int n = 0;
if (a.Length % 2 != 0) n = a.Length / 2 + 1;
else n = a.Length / 2;
Console.WriteLine(n);
for (int i = 0;i<n*2; i+=2)
{
    if (max < a[i]) a[i]=i;
}
Console.WriteLine("Итоговый массив: ");
for (int i = 0; i < a.Length; i++)
{
    Console.Write("{0:f} ", a[i]);
}*/
#endregion

#region 2_14
/*int[] a = new int[] { 1, -2, -3, 8, 6, 45545, 799 };
int max = a[0], otr = 0, indexMax = 0, k=0 ;
for (int i = 0; i < a.Length; i++)
{
    if ((a[i] < 0)&&(k==0))
    {
        otr = i;
        k += 1;
    }
    if (a[i] > max) 
    {
        indexMax = i;
        max = a[i];
    }
}
k = a[otr];
a[otr] = a[indexMax];
a[indexMax]= k;
Console.WriteLine("Итоговый массив: ");
for (int i = 0;i < a.Length;i++) Console.Write("{0:f} ",a[i]);*/
#endregion

#region 2_15
/*int k = 3;
int n = 10;
int m = 5;
int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[] B = new int[] { 999, 2, 3, 4,999 };
for (int i = 0;i<n; i++)
{
    Console.Write("{0:d} ", A[i]);
    if (i == (k - 1))
    {
        for (int j = 0; j < m; j++) Console.Write("{0:d} ",B[j]);
    }
}*/
#endregion

#region 2_16
/*int[] a = new int[] { 1, 2, 3, 8, 6, 3, 3 };
double sum = 0, nul = 0;
int k=0;
for (int i=0; i<a.Length; i++)
{
    sum += a[i];
}
nul = sum / a.Length;
Console.WriteLine(a.Length);
Console.WriteLine(nul);
int[] b = new int[a.Length];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] < nul)
    {
        b[k] = i;
        k++;
    }
}
Console.WriteLine("Итоговый массив: ");
for (int i=0;i<k;i++) Console.Write("{0:d} ",b[i]);*/
#endregion

#region 2_17
/*int[] a = new int[] { 1, -3, 8, 6, -9, 43 };
double sum1 = 0, k1 = 0, sum2=0, k2=0;
double max = a[0], min = a[0],indexMax=0,indexMin=0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        sum1 += a[i];
        k1++;
    }
    if (a[i] < 0)
    {
        sum2 += a[i];
        k2++;
    }
    if (a[i] > max)
    {
        max = a[i];
        indexMax = i;
    }
    if (a[i] < min)
    {
        min = a[i];
        indexMin = i;
    }
}
Console.WriteLine(max);
Console.WriteLine(min);
if (indexMax < indexMin) Console.WriteLine(sum1/k1);
else Console.WriteLine(sum2/k2);*/
#endregion

#region 2_18
/*int[] a = new int[] { 1, -3, 8, 6, -9, 4,1,233,43,5 };
double maxCh = a[0], indexCh = 0;
double maxNeCh = a[1], indexNeCh = 0;
for (int i = 0;i< a.Length; i++)
{
    if ((i%2 == 0)&&(a[i] > maxCh))
    {
        maxCh = a[i];
        indexCh = i;
    }
    else if ((i % 2 != 0) && (a[i] > maxNeCh))
    {
        maxNeCh = a[i];
        indexNeCh = i;
    }
}
Console.WriteLine(maxCh);
Console.WriteLine(maxNeCh);
if (maxCh>maxNeCh)
{
    for (int i=0; i< a.Length / 2; i++) a[i] = 0;
}
else for(int i = (a.Length / 2) -1 ; i < a.Length; i++) a[i] = 0;
Console.WriteLine("Итоговый массив: ");
for (int i = 0; i < a.Length; i++) Console.Write("{0:f} ", a[i]);*/
#endregion

#region 2_19
/*int[] a = new int[] { 1, 3, 14, 1, 323, 21, 5 };
int index = 0, sum = 0, max = a[0];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > max)
    {
        max= a[i];
        index = i;
    }
    sum += a[i];
}
if ((sum - max) < max) a[index] = 0;
else a[index] = a[index]*2;
for (int i = 0; i < a.Length; i++) Console.Write("{0:f} ", a[i]);*/
#endregion

#region 2_20
/*int[] a = new int[] { -1, 3, -14, 1, 323, 21, 5 };
int sumCh = 0, sumNeCh = 0, k=0, min=a[0], otr=0;
for (int i=0; i < a.Length; i++)
{
    if (i % 2 == 0) sumCh += a[i];
    else sumNeCh += a[i];
    if ((a[i] <= min)&& (a[i]<0))
    {
        min = a[i];
        k += 1;
    }
    if (a[i] < 0) otr++;
}
Console.WriteLine(k);
if ((otr>=2)&&(k>=2)) Console.WriteLine(sumCh);
else Console.WriteLine(sumNeCh);*/
#endregion

//слишком много задач :(

#region 3_4
/*int[] b = new int[] { 9, 2, 54, 1, 54, 7, 6,54 };
int sum = 0, indexMax = 0, max=b[0];
for (int i = 0; i < b.Length; i++)
{
    if (b[i] >= max)
    {
        max = b[i];
        indexMax = i;
    }
}
for (int i = 0; i < b.Length; i++)
{
    if (b[i] == max) 
    {
        b[i] = sum;
        sum += max;
    }
    else sum += b[i];
}
Console.WriteLine(indexMax);
for (int i = 0; i < b.Length; i++) Console.Write("{0:f} ", b[i]);*/
#endregion

#region 3_8
int[] a = new int[] { 19, -3, 14, -2, -1, -165, 5, -65, 33 };
int max = a[0], index=0, k=0;
for (int i=0; i<a.Length; i++)
{
    if (a[i] < 0)
    {
        max = a[i];
        for (int j=(i+1); j < a.Length; j++)
        {
            if ((a[j] > max) && (a[j] < 0))
            {
                max = a[j];
                index = j;
                k = a[i];
                a[i] = a[index];
                a[index] = k;
            }
        }
    }
}
for (int i = 0; i < a.Length; i++) Console.Write("{0:f} ", a[i]);
#endregion
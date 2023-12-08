using System;

class Program
{
    static string Print(int[,] a, int strok, int stolb)
    {
        Console.WriteLine();
        for (int i = 0; i < strok; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < stolb; j++)
            {
                Console.Write("{0:d}\t", a[i, j]);
            }
        }
        return "";
    }
    static int[,] Filling(int[,] a, int strok, int stolb)
    {
        Random rand = new Random();
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                a[i, j] = rand.Next(1, 99);
            }
        }
        return a;
    }
    #region 5
   /* static void Main(string[] args)
    {
        int[,] A = new int[4, 6]; 
        int[,] B = new int[6, 6];
        int k = 0;
        int[] index_A = new int[5];
        int[] index_B = new int[7];
        int chisl = 0,indexA,indexB;
        A = Filling(A, 4, 6);
        B = Filling(B, 6, 6);
        Print(A, 4, 6);
        Print(B, 6, 6);
        index_A = index_Max(A, 4,0);
        index_B = index_Max(B, 6,0);
        Console.WriteLine("\n\nКоличество строк с МАКС значение в 1 строке - это 1 значение массивов снизу, далее индексы строк для замены");
        for (int i = 0;i < index_A[0]+1;i++) Console.Write("{0:d}\t", index_A[i]);
        Console.WriteLine("\nДля второго массива: ");
        for (int i = 0; i < index_B[0]+1; i++) Console.Write("{0:d}\t", index_B[i]);
        if ((index_A[0] > 0) && (index_B[0] > 0)) 
        {
            if (index_A[0] < index_B[0]) chisl = index_A[0];
            else chisl = index_B[0];
            for (int j = 0; j < chisl; j++)
            {
                indexA = index_A[j+1];
                indexB = index_B[j+1];
                for (int i = 0; i < 6; i++)
                {
                    k = A[indexA, i];
                    A[indexA, i] = B[indexB, i];
                    B[indexB, i] = k;
                }
             
            }
        }
        Console.Write("\n\nИтоговые массивы");
        Print(A, 4, 6);
        Print(B, 6, 6);


    }
    static int [] index_Max(int[,] a, int strok, int stolb)
    {
        int[] b = new int[strok+1];
        int count = 0;
        int max = a[0, 0];
        int k = 0;
        for (int i = 0; i < strok; i++)
        {
            max = a[i, 0];
            k = 0;
            for (int j = 0; j < 6; j++)
            {
                if (a[i, j] > max)
                {
                    k = 1;
                    break;
                }
            }
            if (k == 0)
            {
                count++;
                b[0] = count;
                b[count] = i;
            }
        }
        return b;
    }*/
    #endregion

    static int[,] Filling2(int[,] a, int strok, int stolb)
    {
        for (int i = 0; i < strok; i++)
        {
            Console.Write("Введите значения {0:d} строки через пробел: ", i + 1);
            string s = Console.ReadLine();
            string[] c = s.Split(" ");
            for (int j = 0; j < stolb; j++)
            {
                a[i, j] = int.Parse(c[j]);
            }
        }
        return a;
    }
    #region 11
    /*    static void Main(string[] args)
        {
            Console.Write("Введите кол-во Строк матрицы №1 : ");
            int strok = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во Столбцов матрицы №1 : ");
            int stolb = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во Строк матрицы №2 : ");
            int strok2 = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во Столбцов матрицы №2: ");
            int stolb2 = int.Parse(Console.ReadLine());
            if ((strok == 0) || (stolb == 0)|| (strok2 == 0) || (stolb2 == 0))
            {
                Console.WriteLine("Одна из матриц - Нулевая");
            }
            else
            {
                Console.WriteLine("Для 1-ой матрицы");
                int[,] A = new int[strok, stolb];
                A = Filling2(A, strok, stolb);
                Console.WriteLine("\nМатрица №1");
                Print(A, strok, stolb);
                Console.WriteLine("\n\nДля 2-ой матрицы");
                int[,] B = new int[strok2, stolb2];
                B = Filling2(B, strok2, stolb2);
                Console.WriteLine("\nМатрица №2");
                Print(B, strok2, stolb2);
                int[] A_index = indexs(A, strok, stolb);
                int[] B_index = indexs(B, strok2, stolb2);
                int k = A[A_index[0], A_index[1]];
                A[A_index[0], A_index[1]] = B[B_index[0], B_index[1]];
                B[B_index[0], B_index[1]] = k;
                Console.WriteLine("\n\nИтоговые матрицы");
                Print(A, strok, stolb);
                Print(B, strok2, stolb2);
            }
        }
        static int [] indexs(int[,] a, int strok, int stolb)
        {
            int[] b = new int[2];
            int max = a[0, 0];
            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        b[0] = i;
                        b[1] = j;
                    }
                }
            }
            return b;
        }*/
    #endregion

    #region 17
    /*    static void Main(string[] args)
        {
            Console.Write("Введите кол-во Строк матрицы №1 : ");
            int strok = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во Столбцов матрицы №1 : ");
            int stolb = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во Строк матрицы №2 : ");
            int strok2 = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во Столбцов матрицы №2: ");
            int stolb2 = int.Parse(Console.ReadLine());
            if ((strok == 0) || (stolb == 0) || (strok2 == 0) || (stolb2 == 0))
            {
                Console.WriteLine("Одна из матриц - Нулевая");
            }
            else
            {
                Console.WriteLine("Для 1-ой матрицы");
                int[,] A = new int[strok, stolb];
                A = Filling2(A, strok, stolb);
                Console.WriteLine("\nМатрица №1");
                Print(A, strok, stolb);
                Console.WriteLine("\n\nДля 2-ой матрицы");
                int[,] B = new int[strok2, stolb2];
                B = Filling2(B, strok2, stolb2);
                Console.WriteLine("\nМатрица №2");
                Print(B, strok2, stolb2);
                A = Sort(A, strok, stolb);
                B = Sort(B, strok2, stolb2);
                Console.WriteLine("\n\nИтоговые матрицы");
                Print(A, strok, stolb);
                Print(B, strok2, stolb2);
            }
        }
        static int[,] Sort(int[,] a, int stolb, int strok)
        {
            int MaxMax, max, index = 0, k;
            for (int i = 0; i < stolb; i++)
            {
                index = i;
                MaxMax = a[i, 0];
                for (int i2 = i; i2 < stolb; i2++)
                {
                    max = a[i2, 0];
                    for (int j = 0; j < strok; j++)
                    {
                        if (a[i2, j] > max) max = a[i2, j];
                    }
                    if (max > MaxMax)
                    {
                        MaxMax = max;
                        index = i2;
                    }
                }
                if (index != i)
                {
                    for (int j = 0; j < strok; j++)
                    {
                        k = a[index, j];
                        a[index, j] = a[i, j];
                        a[i, j] = k;
                    }
                }
            }
            return a;
        }*/
    #endregion
    static double[,] Filling23(double[,] a, int strok, int stolb)
    {
        for (int i = 0; i < strok; i++)
        {
            Console.Write("Введите значения {0:d} строки через пробел: ", i + 1);
            string s = Console.ReadLine();
            string[] c = s.Split(" ");
            for (int j = 0; j < stolb; j++)
            {
                a[i, j] = double.Parse(c[j]);
            }
        }
        return a;
    }
    #region 23
    static void Main(string[] args)
    {
        Console.Write("Введите кол-во Строк матрицы №1 : ");
        int strok = int.Parse(Console.ReadLine());
        Console.Write("Введите кол-во Столбцов матрицы №1 : ");
        int stolb = int.Parse(Console.ReadLine());
        Console.Write("Введите кол-во Строк матрицы №2 : ");
        int strok2 = int.Parse(Console.ReadLine());
        Console.Write("Введите кол-во Столбцов матрицы №2: ");
        int stolb2 = int.Parse(Console.ReadLine());
        if ((strok == 0) || (stolb == 0) || (strok2 == 0) || (stolb2 == 0))
        {
            Console.WriteLine("Одна из матриц - Нулевая");
        }
        else
        {
            Console.WriteLine("\nДля 1-ой матрицы");
            double[,] A = new double[strok, stolb];
            A = Filling23(A, strok, stolb);

            Console.WriteLine("\n\nДля 2-ой матрицы");
            double[,] B = new double[strok2, stolb2];
            B = Filling23(B, strok2, stolb2);

            strannoe_yslovie(A, strok, stolb, 1);
            Console.WriteLine();
            strannoe_yslovie(B, strok2, stolb2, 2);

        }
    }

    static double[,] strannoe_yslovie(double[,] a, int strok1, int stolb1, int znach)
    {
        int dlinn = strok1 * stolb1;
        if (dlinn >= 5)
        {
            double[] c = new double[dlinn];
            double max, k2;
            int k = 0, index;
            for (int i = 0; i < strok1; i++)
            {
                for (int j = 0; j < stolb1; j++)
                {
                    c[k] = a[i, j];
                    k++;
                }
            }

            for (int i = 0; i < dlinn; i++)
            {
                index = i;
                max = c[i];
                for (int j = i; j < dlinn; j++)
                {
                    if (c[j] > max)
                    {
                        max = c[j];
                        index = j;
                    }
                }
                k2 = c[i];
                c[i] = max;
                c[index] = k2;
            }
            Console.WriteLine("\nМаксимальные значения {0:d} матрицы ", znach);
            for (int i = 0; i < 5; i++) Console.Write("{0:f2}\t", c[i]);
            for (int i = 0; i < strok1; i++)
            {
                for (int j = 0; j < stolb1; j++)
                {
                    k = 0;
                    for (int n = 0; n < 5; n++)
                    {
                        if (a[i, j] == c[n])
                        {
                            a[i, j] = a[i, j] * 2;
                            k = 1;
                            break;
                        }
                    }
                    if (k == 0)
                    {
                        a[i, j] = a[i, j] / 2;
                    }
                    k = 0;
                }
            }
            Console.Write("\nИтоговая матрица №{0:d}", znach);
            for (int i = 0; i < strok1; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < stolb1; j++)
                {
                    Console.Write("{0:f2}\t", a[i, j]);
                }
            }
        }
        else Console.WriteLine("Недостаточно значений");
        return a;
    }
    #endregion
}
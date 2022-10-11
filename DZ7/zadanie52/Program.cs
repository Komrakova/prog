// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("задайте размерность массива");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[M,N];
double[] summa = new double[N];
for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            matrix[i,j] = new Random().Next(0,11);
            summa[j] = summa[j] + matrix[i,j];

        }

    }
Console.WriteLine("Ваш массив:");
for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
 Console.WriteLine("Среднее арифметическое элементов:");   
 for(int j = 0; j < N; j++)
        {
            double SredneeArif = summa[j]/M;
            SredneeArif = Math.Round(SredneeArif,2);
            Console.WriteLine($"В {j + 1} столбце: {SredneeArif} ");
        }
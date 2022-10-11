// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("задайте размерность массива");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[M,N];
for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            int numb = new Random().Next(-22,23);
            matrix[i,j] = new Random().NextDouble() * numb;
            matrix[i,j] = Math.Round(matrix[i,j], 2);
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
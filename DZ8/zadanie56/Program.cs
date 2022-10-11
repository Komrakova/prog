// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("задайте размерность прямоугольного массива");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[M,N];
int[] summa = new int[M];
if (M <= N) Console.WriteLine("Ошибка! Размерность массива задана неверно!");
else
{
    Console.WriteLine("Ваш массив:");
    for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            matrix[i,j] = new Random().Next(0,11);
            Console.Write($"{matrix[i,j]} ");
            summa[i] = summa[i] + matrix[i,j];

        }
        Console.WriteLine();
    }

    int min = summa[0];
    int imin = 0;
    for(int i = 1; i < M; i++)
    {    
    if (summa[i] < min)
        {
            min = summa[i];
            imin = i;
        }
    }
    
    Console.WriteLine($"Наименьшая сумма элементов в {imin + 1} строке");

}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("задайте размерность массива");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[M,N];
for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            matrix[i,j] = new Random().Next(-100,101);

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
Console.WriteLine("Введите номер строки и номер столца нужного элемента");
int iNumb = Convert.ToInt32(Console.ReadLine());
int jNumb = Convert.ToInt32(Console.ReadLine());

if (iNumb > 0 & iNumb <= M & jNumb > 0 & jNumb <= N)
{
    Console.WriteLine($"Ваше число = {matrix[iNumb-1,jNumb-1]}");
     
}
else Console.WriteLine("Ошибка: такого числа в массиве нет");
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
            matrix[i,j] = new Random().Next(-1000,1001);

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
Console.WriteLine("Введите число от -1000 до 1000");
int Numb = Convert.ToInt32(Console.ReadLine());
int iNumb = -1;
int jNumb = -1;
if (Numb > -1001 & Numb < 1001)
{
   for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            if (Numb == matrix[i,j]) 
            {
                iNumb = i;
                jNumb = j;
                Console.WriteLine($"Позиция вашего числа в массиве строка = {iNumb + 1} столбец = {jNumb + 1}");
            }

        }
    }
    if (iNumb == -1 & jNumb == -1) Console.WriteLine("В массиве нет такого числа");
}
else Console.WriteLine("Ошибка: число не попадает в заданный интервал");
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("задайте размерность массива");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[M,N];
Console.WriteLine("Ваш массив:");
for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            matrix[i,j] = new Random().Next(0,11);
            Console.Write($"{matrix[i,j]} ");

        }
        Console.WriteLine();
    }

for(int i = 0; i < M; i++)
    {
        int newN = N;
        while (newN != 2)
        {
            int max = matrix[i,0];
            for (int j = 1; j < newN; j++)
            {
                if (matrix[i,j] > matrix[i,j-1]) 
                {   
                    max = matrix[i,j];
                }
                else 
                {
                    matrix[i,j-1] = matrix[i,j];
                    matrix[i,j] = max;
                }
            }
        newN = newN-1;
              
        }  
        
    }
Console.WriteLine("Отсортированный массив: ");
for(int i = 0; i < M; i++)
    {
        for(int j = 0; j < N; j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("задайте размерность массива");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrixOne = new int[M,N];
int[,] matrixTwo = new int[M,N];
int[,] matrixThree = new int[M,N];

for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        matrixOne[i,j] = new Random().Next(0,11);
        matrixTwo[i,j] = new Random().Next(0,11);
        matrixThree[i,j] = matrixOne[i,j] * matrixTwo[i,j];
    }
}
Console.WriteLine("Первый массив");
PrintMatrix(matrixOne);
Console.WriteLine();
    
Console.WriteLine("Второй массив");
PrintMatrix(matrixTwo);
Console.WriteLine();

Console.WriteLine("Произведение элементов массива");
PrintMatrix(matrixThree);


// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.WriteLine("задайте размерность массива");

//int M = 4;
int M = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[M,M];
int counter = 0;
matrix[0,0] = 1;

while(counter < M/2)
{
    for(int i = 1; i < M-counter; i++) matrix[counter,i] = matrix[counter,i-1] + 1;
    for(int i = 1+counter; i < M-counter; i++) matrix[i,M-1-counter] = matrix[i-1,M-1-counter] + 1;
    for(int i = M-1-counter; i > counter; i--) matrix[M-1-counter,i-1] = matrix[M-1-counter,i] + 1;
    for(int i = M-2-counter; i > counter; i--) matrix[i-counter,counter] = matrix[i-counter+1,counter] + 1;
    counter++;

}

Console.WriteLine("Ваш массив:");
for(int i = 0; i < M; i++)
{
    for(int j = 0; j < M; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}

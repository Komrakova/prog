//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
Console.WriteLine("задайте размерность трехмерного массива");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int K = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[M, N, K];
int[] numb = new int[M * N * K];
int inumb = 0;
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        for (int k = 0; k < K; k++)
        {
            array3D[i,j,k] = new Random().Next(10, 100);
            numb[inumb] = array3D[i,j,k];
            for (int l = 0; l < M * N * K; l++)
            {
                if (array3D[i,j,k] == numb[inumb]) 
                {
                    array3D[i,j,k] = array3D[i,j,k] + 1;
                }
            }
            Console.Write($" {array3D[i,j,k]} ({i+1}, {j+1}, {k+1})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




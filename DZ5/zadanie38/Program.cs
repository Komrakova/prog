// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int min = 100;
int max = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,99);
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write($" {array[i]}"); 
}
int diff = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве = {diff}");
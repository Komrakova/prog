// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,999);
    int ostatok = array[i] % 2;
    
    if (ostatok == 0 ) sum++;
}
Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write($" {array[i]}"); 
}
Console.WriteLine();
Console.WriteLine($"Число всех четных чисел в массиве = {sum}");
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,99);
    int ostatok = i % 2;
    if (ostatok != 0) sum = sum + array[i];
}
Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write($" {array[i]}"); 
}
Console.WriteLine();
Console.WriteLine($"Сумма всех нечетных элементов в массиве = {sum}");
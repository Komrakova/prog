// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

Console.WriteLine("Введите 8 чисел");
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вы ввели: ");
for (int i = 0; i < 8; i++)
{
    Console.Write($" {array[i]}"); 
}
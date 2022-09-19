﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int size = 123;

int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,150);
    if (array[i] > 9 && array[i] < 100 ) sum++;
}
Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write($" {array[i]}"); 
}
Console.WriteLine();
Console.WriteLine($"Число всех чисел в интервале от 10 до 99 в массиве = {sum}");
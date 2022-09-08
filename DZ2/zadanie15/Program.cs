// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, которое соответствует дню недели");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 1 || numb > 7)
{
    Console.WriteLine("Неверно задано число!");
}
else
{
    if (numb > 0 && numb < 6)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb > 99 && numb < 1000)
{
    int digit1 = numb / 10;
    int digit2 = digit1 % 10;
    Console.WriteLine("Второе число " + digit2);
}
else
{
    Console.WriteLine("Ошибка: число не трехзначное!");
}
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 99 && numb > -99)
{
    Console.WriteLine("Нет третьей цифры!");
}
else
{
    while (numb > 999 || numb < -999)
    {
        numb = numb / 10;
    }
    
    int digit = numb % 10;
    Console.WriteLine("Третья цифра " + digit);
}
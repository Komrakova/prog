// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите натуральное пятизначное число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 10000 || numb > 99999 )
{
    Console.WriteLine("Ошибка! Введенное число не натуральное или не пятизначное");
}
else
{
    int count = numb;
    int backnumb = 0;
    while (count > 0)
    {
        int digit = count % 10;
        backnumb = backnumb * 10 + digit;
        count = count / 10;
    }
    Console.WriteLine("обратное число " + backnumb);
    if (numb == backnumb)  
    {
        Console.WriteLine("Ваше число - палиндром");
    }
    else
    {
        Console.WriteLine("Ваше число - не палиндром");
    }
}  
    

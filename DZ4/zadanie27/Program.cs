// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());

int sum = 0;
numb = Math.Abs(numb);
int ostatok = numb;
while(ostatok != 0)
{
    ostatok = numb % 10;
    sum = sum + ostatok;
    numb = numb / 10;

} 
Console.WriteLine($"Сумма всех цифр в числе = {sum}");
 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
int ostatok = numb % 2;

if(ostatok == 0) 
{
   Console.WriteLine("Ваше число четное");
}
else
{
    Console.WriteLine("Ваше число нечетное");
}
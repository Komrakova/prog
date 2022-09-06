//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа");
int numb1 = Convert.ToInt32(Console.ReadLine());
int numb2 = Convert.ToInt32(Console.ReadLine());

if(numb2 > numb1) 
{
    Console.WriteLine("Максимальное число " + numb2);
    Console.WriteLine("Минимальное число " + numb1);
}
else
{
    Console.WriteLine("Максимальное число " + numb1);
    Console.WriteLine("Минимальное число " + numb2);
}
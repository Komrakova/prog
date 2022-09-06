// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count < numb)
{
    int ostatok = count % 2;
    if(ostatok == 0) Console.Write(count + " ");
    count++;
}

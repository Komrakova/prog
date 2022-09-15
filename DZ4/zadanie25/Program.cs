// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите 2 натуральных числа");
int numbA = Convert.ToInt32(Console.ReadLine());
int numbB = Convert.ToInt32(Console.ReadLine());
if (numbA < 0 || numbB < 0 )
{
    Console.WriteLine("Ошибка! Введенное число не натуральное");
}
else
{
   int res = 1;
   for (int i = 1; i <= numbB; i++)
        {
            res = res * numbA;
            
        } 
    Console.WriteLine($"A в степени В = {res}");
}  
    


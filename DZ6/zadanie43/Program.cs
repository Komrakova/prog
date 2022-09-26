// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("введите k1 и b1 для первой прямой");
double Kone = Convert.ToDouble(Console.ReadLine());
double Bone = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите k2 и b2 для второй прямой");
double Ktwo = Convert.ToDouble(Console.ReadLine());
double Btwo = Convert.ToDouble(Console.ReadLine());

double X = (Bone - Btwo)/(Ktwo - Kone);
Console.WriteLine($"Х = {X}");
double Y = Kone * X + Bone;
Console.WriteLine($"Y = {Y}");
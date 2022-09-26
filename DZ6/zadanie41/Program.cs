// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите число. Для завершения ввода наберите stop");
int sum = 0;
string input = "0";
while (input != "stop" || input != "Stop")
{
    if (input == "stop" || input == "Stop" ) break;
    input = Console.ReadLine();
    double.TryParse(input, out double numb);
           if (numb > 0) sum++;
}


Console.WriteLine();
Console.WriteLine($"Колличество чисел больше нуля = {sum}");
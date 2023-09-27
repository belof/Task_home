// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine ("Введите 3-х значное число:");
int num = int.Parse(Console.ReadLine()??"0");git
double digit = Math.Log10(num);
digit = (int)digit;
if (digit == 2)
{
    // отсекаем последнюю цифру 
    int result = num / 10;
    // получаем вторую цифру 
    result = result%10;
    // Выводим результат в консоль
    Console.WriteLine ("Вторая цифра числа: " + num + " равна: " + result);
}
else
{
    Console.WriteLine ("Введенное число не 3-х значное!!!");
    Console.WriteLine ("Введите 3-х значное!!! число!!!");
}
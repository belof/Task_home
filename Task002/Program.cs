﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string? inputNum1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string? inputNum2 = Console.ReadLine();

if (inputNum1 != null && inputNum2 != null)
{
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    if (number1 > number2)
    {

        Console.Write("Первое число: ");
        Console.Write(number1);
        Console.Write(" Больше второго числа: ");
        Console.Write(number2);
        Console.WriteLine(" и является максимальным. ");
    }
    else
    {

        Console.Write("Первое число: ");
        Console.Write(number1);
        Console.Write(" Меньше второго числа: ");
        Console.Write(number2);
        Console.WriteLine(" и является минимальным. ");
    }
}
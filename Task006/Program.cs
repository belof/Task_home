﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Вводим данные с консоли первое число
Console.WriteLine("Целое число:");
string? inputNum = Console.ReadLine();


// if проверка на нулевое значение
if (inputNum != null)
{
    //конвертация строки в число
    int number = int.Parse(inputNum);
    // проверяем условие если остаток от деления на 2 == 0
    if ((number % 2) == 0)
    {
         // Вывод результата если условие верно
         Console.WriteLine("введенное число является четным");
    }
    else
    {
        // Вывод результата если условие не соблюдается
        Console.WriteLine("введенное число является не четным");
    }
}
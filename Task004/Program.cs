// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Вводим данные с консоли первое число 
// Console.WriteLine Записывает указанные данные с текущим признаком конца строки в стандартный выходной поток.

Console.WriteLine("Введите первое число:");
string? inputNum1 = Console.ReadLine();

// Вводим данные с консоли второе число
// Console.WriteLine Записывает указанные данные с текущим признаком конца строки в стандартный выходной поток.
Console.WriteLine("Введите второе число:");
string? inputNum2 = Console.ReadLine();

// Вводим данные с консоли третье число
// Console.WriteLine Записывает указанные данные с текущим признаком конца строки в стандартный выходной поток.
Console.WriteLine("Введите третье число:");
string? inputNum3 = Console.ReadLine();

// if проверка на нулевое значение
// Конструкция if/else проверяет истинность некоторого условия и в зависимости от результатов проверки выполняет определенный код.
if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
    //конвертация строки в число
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    int number3 = int.Parse(inputNum3);

    // объявляем переменную maximum и присваиваем ей значение первого числа
    int maximum = number1;

    // Сравниваем maximum с остальными числами
    if (number2 > number1)
        maximum = number2;
    if (number3 > maximum)
        maximum = number3;

    // выводим ответ в консоль
    Console.Write("Максимальное число равно: ");
    Console.WriteLine(maximum);

}
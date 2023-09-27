// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите положительное число");
char[] digits = Console.ReadLine().ToCharArray();

 if ( digits.Length > 2)
 {

    Console.Write("Третья цифра в числе: ");
    Console.Write(digits);
    Console.Write(", равняется: ");
    Console.WriteLine(digits[2]);
 }
else
{
    Console.Write("Третья цифра в числе: ");
    Console.Write(digits);
    Console.WriteLine(", отсутствует!");
}
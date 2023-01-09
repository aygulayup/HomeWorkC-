// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 99 && num > -99) Console.WriteLine($"{num} -> третьей цифры нет");
else
{
    while (num > 999 || num < -999)
{
    num = num / 10;
}
int result = num % 10;

if (result < 0) Console.WriteLine(-result);
else Console.WriteLine(result);

}


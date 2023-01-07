// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456-> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int MakeDigit(int number)
{
int result = (number/10) % 10;
return result;
}

int newDigit = MakeDigit(num);
Console.WriteLine($"{num} -> {newDigit}");
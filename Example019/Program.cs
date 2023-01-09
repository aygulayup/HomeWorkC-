// Задача 19. Напишите программу, 
// которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 100000 || num < 10000)
{
    Console.WriteLine("Введите корректное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int firstDigit = num / 10000;
int secDigit = num / 1000 % 10;
int fourthDigit = num / 10 % 10;
int fifthDigit = num % 10;

if (firstDigit == fifthDigit && secDigit == fourthDigit)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}









// int MakeDigit(int number)
// {
// int result = (number/100)*10 + number % 10;
// return result;
// }

// int newDigit = MakeDigit(rnd);
// Console.WriteLine($" {rnd} -> {newDigit}");
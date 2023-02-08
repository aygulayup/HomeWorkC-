// Задача 27: Напишите программу, 
// 1. которая принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11


int InsertDigit(string text) 
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumDigit(int num) 
{
    int result = 0;
    int digit = 0;
    if(num % 10 !>= 0) 
    {
        digit = num % 10;
        result = result + digit;
        num = num / 10;
    }
    return result;
}

int number = InsertDigit("Введите число: ");
int sumDigits = SumDigit(number);
Console.WriteLine($"{number} -> {sumDigits}");


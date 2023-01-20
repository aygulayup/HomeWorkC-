// Задача 27: Напишите программу, 
// 1. которая принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11

// Вы не могли бы помочь разобраться с кодом? Не понимаю некоторые пункты.
// //Почему то с циклом while код не запускается..
// По модулю взять введенное пользователем число знаком ! перед > не получается
// И в итоге, если ввести отрицательное число, то выводит 0
// цикл вообще не работает) в результат выводит последнюю цифру числа и все.

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


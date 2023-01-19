// Задача 25: Напишите цикл, 
// 1. который принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int PowerNum(int num1, int num2)
{
    int result = 1;

    // while (num2 <= 0)
    // {
    //     num2 = InsertDigit("Введите корректное число B: ");
    // }

    for (int i = 1; i <= num2; i++)
    {
        result = num1 * num1;
    }
    return result;
}

int numA = InsertDigit("Введите число A: ");
int numB = InsertDigit("Введите число В: ");
int powerOfNum = PowerNum(numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} = {powerOfNum}");
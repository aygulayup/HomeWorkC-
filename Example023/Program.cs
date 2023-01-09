// Задача 23 Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
    int num = Convert.ToInt32(Console.ReadLine());

while (num < 1)
{
    Console.WriteLine("Введите корректное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

    SquareNum(num);

void SquareNum(int number)
{
    int index = 1;
    while (index <= number) 
    {
        Console.WriteLine($"{index, 3} -> {index * index * index, 3}");
        index ++;
    }
}
// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число от 1 до 7.");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7) 
{ 
    Console.Write("Введите корректное число: ");
}

else
{
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine($"{num} -> нет.");
    } 
    
    else
    {
     Console.WriteLine($"{num} -> да.");
    }
    
}
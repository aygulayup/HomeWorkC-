// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int colomns, int min, int max) //создание и заполнение массива случайными элементами
{
    int [,] matrix = new int[rows, colomns]; 
    Random rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(min, max + 1);
    }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)// вывод массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
 
    Console.Write("["); 
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, "); 
        else Console.Write($"{matrix[i, j], 4} ");
    }
    Console.WriteLine("]");
    }
}

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FindMatrixElement(int[,] matr, int digit1, int digit2)//поиск элемента по адресу
{
    
    if (digit1 > 0 && digit1 <= matr.GetLength(0) &&
        digit2 > 0 && digit2 <= matr.GetLength(1))
    {
        Console.WriteLine(matr[digit1, digit2]);
    }
    else
    {
        Console.WriteLine("-> такого элемента в массиве нет");
    }
    
}

int[,] arr2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();
int digitNum1 = InsertDigit("Введите число 1: ");
int digitNum2 = InsertDigit("Введите число 2: ");
FindMatrixElement(arr2D, digitNum1, digitNum2);
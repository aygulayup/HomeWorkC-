// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

int[] SumRowDigits(int[,] matrix) // сумма элементов в каждой строке
{
    int [] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
        sum = 0;
    }
    return array;
}

void PrintArray(int [] array)// вывод одномерного массива в консоль
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", "); 
        else Console.Write(array[i]); 
    }
    Console.Write("]");
}

int FindMinSum(int[] array) // номер строки с мин.суммой
{
    int index = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i]) 
        {
            min = array[i];
            index++;
        }
    }
    return index;
}

int[,] arr2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();

int[] arrSumRowDigits = SumRowDigits(arr2D);
Console.Write("Сумма элементов строк равны = ");
PrintArray(arrSumRowDigits);
Console.WriteLine();

int rowWithMinSumOfDigit = FindMinSum(arrSumRowDigits);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowWithMinSumOfDigit} .");

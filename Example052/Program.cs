// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AverageOfColumnDigit(int[,] matrix)// ср.арифметическое столбца
{
    double [] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        array[j] = sum / matrix.GetLength(0);
        array[j] = Math.Round(array[j], 1, MidpointRounding.ToZero);
        sum = 0;
    }
    return array;
}

void PrintArray(double [] array)// вывод массива в консоль
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", "); 
        else Console.Write(array[i]); 
    }
    Console.Write("]");
}

int[,] arr2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();

double[] averagesArr = AverageOfColumnDigit(arr2D);
PrintArray(averagesArr);
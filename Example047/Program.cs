// Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int colomns, int min, int max) //создание и заполнение массива случайными элементами
{
    double [,] matrix = new double[rows, colomns]; 
    Random rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Convert.ToDouble(rnd.Next(min, max)/10.0);
    }
    }
    
    return matrix;
}

void PrintMatrix(double [,] matrix)// вывод массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
 
    Console.Write("["); //вывод массива на экран в [скобках]
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, "); // вывод эл-ов массива через запятую
        else Console.Write($"{matrix[i, j], 4} "); 
    }
    Console.WriteLine("]");
    }
}

double[,] newDoubleMatrix = CreateMatrixRndDouble(3, 4, -100, 100);
PrintMatrix(newDoubleMatrix);
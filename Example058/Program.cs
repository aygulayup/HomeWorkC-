// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int [,] MultipleMatrix(int[,] matr1, int[,] matr2)
{
    int [,] matrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int temp = 0; temp < matrix.GetLength(1); temp++)
            {
                matrix[i, j] += matr1[i, temp] * matr2[temp, j];
            }
        }
    }
    return matrix;
}


int[,] matrix1 = CreateMatrixRndInt(2, 4, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();

if(matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Умножение невозможно");
else
{
    Console.WriteLine("Итоговая матрица: ");
    int[,] multMatrix = MultipleMatrix(matrix1, matrix2);
    PrintMatrix(multMatrix);
}





// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortRowMaxToMin(int[,] matrix) 
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 1; j < matrix.GetLength(1); j++) 
        { 
            for (int n = 0; n < matrix.GetLength(1) - 1; n++) 
            { 
                int count = 0; 
                if (matrix[i, n + 1] > matrix[i, n]) 
                { 
                    count = matrix[i, n + 1]; 
                    matrix[i, n + 1] = matrix[i, n]; 
                    matrix[i, n] = count; 
                } 
            } 
        } 
    } 
    return matrix; 
}
int[,] arr2D = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();

int[,] sortFromMaxToMin = SortRowMaxToMin(arr2D);
PrintMatrix(sortFromMaxToMin);



// int[,] MaxToMinRowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
            
//             for (int temp = 0; temp < (matrix.GetLength(1) - 1); temp++)
//             {
//                 int index = matrix.GetLength(1) - 1;
//                 int maxDigit = matrix[i, temp];
//                 if(maxDigit < matrix[i, index])
//                 {
//                     int count = matrix[i, index];
//                     matrix[i, index] = matrix[i, temp];
//                     matrix[i, temp] = count;
//                     index = index - 1;
//                 }
//                 else index = index - 1;
//             }    
//         }
        
//     }
//     return matrix;
// }
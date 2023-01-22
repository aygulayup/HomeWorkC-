// Задача 38: 
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max) //создание и заполнение массива вещественных чисел
{
    double [] array = new double[size]; // новое место памяти для массива
    Random rnd = new Random(); // новое место памяти для элемента класса Random
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min; // для получения чисел из заданного диапазона
        array[i] = Math.Round(array[i], 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArrayDouble(double [] array)// вывод массива в консоль
{
    Console.Write("["); //вывод массива на экран в [скобках]
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", "); // вывод эл-ов массива через запятую
        else Console.Write(array[i]); // обратиться к последнему элементу массива array[^1]
    }
    Console.Write("]");
}

double FindMax(double [] array)
{
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > result) result = array[i];   
    }
    return result;
}

double FindMin(double [] array)
{
    double result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < result) result = array[i];   
    }
    return result;
}


int sizeArray = 4, arrayMin = 0, arrayMax = 100;
double[] arr = CreateArrayRndDouble(sizeArray, arrayMin, arrayMax);
PrintArrayDouble(arr);

double divMaxMin = FindMax(arr) - FindMin(arr);
divMaxMin = Math.Round(divMaxMin, 1, MidpointRounding.ToZero);

Console.WriteLine($" -> {divMaxMin}");

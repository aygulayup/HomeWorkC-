// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// у = k1 * x + b1, y = k2 * x + b2;

// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


string InsertNumbers(string text) //метод ввода чисел пользователем
{
    Console.WriteLine(text);
    string result = Console.ReadLine();
    return result;
}

string[] StringToArray(string userNumbers) //перевод строки в массив строк
{
    string str = userNumbers;
    string[] strArr = str.Split(",");
    return strArr;
}

double[] ConvertStringToDoubleArr(string[] stringArray)//конвертирование массива строк в массив чисел
{
    double[] doubleArr = new double[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        doubleArr[i] = Convert.ToDouble(stringArray[i]);
    }
    return doubleArr;
}

// void FindX(int[] userNumbers)
// {
//     int b1 = userNumbers[0];
//     int k1 = userNumbers[1];
//     int b2 = userNumbers[2];
//     int k2 = userNumbers[3];
//     int x; int y;
//     y = k1 * x + b1;
//     x = (y - b1) / k1;

//     y = k2 * x + b2;
//     x = (y - b2) / k2;
// }

double CrossX (double[] userNumbers)
{
    double b1 = userNumbers[0];
    double k1 = userNumbers[1];
    double b2 = userNumbers[2];
    double k2 = userNumbers[3];
    double x = (b2 - b1) / (k1 - k2); // = (4 - 2) / (5 - 9) = 2 / -4 = -0,5
    return x;
 }

double CrossY (double[] userNumbers, double x)
{
    double b1 = userNumbers[0];
    double k1 = userNumbers[1];
    double b2 = userNumbers[2];
    double k2 = userNumbers[3];
    double y = k1 * x + b1; //= 5 * (-0,5) + 2 = -0,5
    return y;
}
 
string insertNumbers = InsertNumbers("Введите b1, k1, b2 и k2 через запятую");
string[] userArray = StringToArray(insertNumbers);
double[] numberArray = ConvertStringToDoubleArr(userArray);
double findCrossX = CrossX(numberArray);
double findCrossY = CrossY(numberArray, findCrossX);
Console.WriteLine($"точка пересечения прямых -> ({findCrossX}, {findCrossY})");




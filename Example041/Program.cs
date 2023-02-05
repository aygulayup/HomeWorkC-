// Задача 41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// string str = "3,5,6,8,0, -34";
// string[] strArr = str.Split(',');

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

void PrintStringArray(string[] array) // печать массива строк
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", "); 
        else Console.Write(array[i]); 
    }
    Console.Write("]");
}

int[] ConvertStringToIntArr(string[] stringArray)//конвертирование массива строк в целочисленный массив
{
    int[] intArr = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        intArr[i] = Convert.ToInt32(stringArray[i]);
    }
    return intArr;
}

void PrintArray(int[] array) //печать целочисленного массива
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", "); 
        else Console.Write(array[i]); 
    }
    Console.Write("]");
}

int CountPositiveNumber(int[] array) // подсчет положительных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count ++;
    }
    return count;
}


string insertNumbers = InsertNumbers("Введите числа через запятую: ");
Console.WriteLine();

string[] userArray = StringToArray(insertNumbers);
PrintStringArray(userArray);
Console.WriteLine();

int[] numberArray = ConvertStringToIntArr(userArray);
PrintArray(numberArray);

int countPositive = CountPositiveNumber(numberArray);
Console.WriteLine($"-> {countPositive}");


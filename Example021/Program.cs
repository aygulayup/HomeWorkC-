// Задача 21 Напишите программу, 
// которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = InsertPositon("Введите координату Х первой точки:"); 
int y1 = InsertPositon("Введите координату У первой точки:");
int z1 = InsertPositon("Введите координату Z первой точки:");
int x2 = InsertPositon("Введите координату X второй точки:"); 
int y2 = InsertPositon("Введите координату Y второй точки:");
int z2 = InsertPositon("Введите координату Z первой точки:");


double distance = Distance(x1, y1, z1, x2, y2, z2);
double disToZero = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine(disToZero);


int InsertPositon(string text)
{
    Console.Write(text);
    int pos = Convert.ToInt32(Console. ReadLine());
    return pos;
}

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    int distance = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za);
    return Math.Sqrt(distance);
}

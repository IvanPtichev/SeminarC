// Задача1: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Input an x-coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

double quadNum = FindQuadrant(xA, yA);

Console.WriteLine($"The point a({xA}, {yA}) is on the {quadNum} quadrant");
*/
// Задача2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void Range(int quadrant)
{
    if(quadrant == 1) Console.Write("x > 0, y > 0");
    else if(quadrant == 2) Console.Write("x < 0, y > 0");
    else if(quadrant == 3) Console.Write("x < 0, y < 0");
    else if(quadrant == 4) Console.Write("x > 0, y < 0");
    else
    {
        Console.WriteLine("wrong number entered");
    }
}

Console.WriteLine("enter the number of the quarter");
int num = Convert.ToInt32(Console.ReadLine());
Range(num);
*/
// Задача3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Hypotenuse(double xA,double xB,double yA,double yB)
{
    double length = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2));
    return Math.Round(length, 2); 
}

Console.WriteLine("imput an x-coordinate of point A");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an x-coordinate of point B");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an y-coordinate of point A");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("imput an y-coordinate of point B");
double yB = Convert.ToDouble(Console.ReadLine());

double result = Hypotenuse(xA, xB, yA, yB);

Console.Write($"hypotenuse = {result} ");
*/
// Задача4: Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.
/*
void Squares(int num)
{
    int counter = 1;
    while(counter <= num)
    {
    Console.Write(Math.Pow(counter, 2));
    if(counter != num) Console.Write(", ");
    else Console.Write(".");
    counter++;
    }
}
Console.WriteLine("impun number");
int numA = Convert.ToInt32(Console.ReadLine());
Squares(numA); 
*/
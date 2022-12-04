// Задача1: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого чис

/*

 int CutNumber(int num)
 {
     int ed = num % 10;
      int sot = num / 100;

      int result = sot * 10 + ed;
      return result;
}

 int randNum = new Random().Next(100, 1000);
 int newNum = CutNumber(randNum);

 Console.WriteLine($"New version of a number {randNum} is {newNum}");
*/

// Задача2: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
/*
int Max(int max)
{
    int numA = max / 10;
    int numB = max % 10;
    if(numA > numB)
    {
        return numA;
    }
    else
    {
        return numB;
    }

}


int randNum = new Random().Next(10, 99);
int newNum = Max(randNum);

Console.WriteLine($"Максимальное число из {randNum} равно {newNum}");
*/


// Задача3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый делитель");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй делитель");
int b = Convert.ToInt32(Console.ReadLine());


if(num % a == 0 && num % b == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}
*/

// Задача 3: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
/*
Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA == numB * numB || numB == numA * numA)
{
    if(numA == numB * numB)
    {
        Console.WriteLine($"{numA} является квадратом {numB}");
    }
    else
    {
        Console.WriteLine($"{numB} является квадратом {numA}");
    }
}
else{
    Console.WriteLine("Ни одно число не является квадратом другого");
}
*/



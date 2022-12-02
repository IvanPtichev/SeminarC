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

int num = Convert.ToInt32(Console.ReadLine());
int a = 5;
int b = 2;


if(num % a == 0 && num % b == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}
// Задача 3: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого







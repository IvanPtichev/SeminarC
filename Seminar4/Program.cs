// Задача1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumOfDigits(int num)
{
    int count = 0;

    while(num != 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

Console.Write("Imput a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);

Console.WriteLine($" Number of digits in {number} is {result}");
*/

// Задача2: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
/*
int SumNumber(int num)
{
   int sum = 0;

    while( num > 0)
    {
        sum = sum + num;
        num -= 1;
    }
    return sum;
}

Console.Write("Imput a num: ");
Int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(number);

Console.WriteLine($"{result}");
*/


// Задача3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int num)
{
   if(num < 0) num *= -1;
   int fact = 1;
    while( num > 0)
    {
        fact = fact * num;
        num -= 1;
    }
    return fact;
}

Console.Write("Imput a num: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Factorial(number);

Console.WriteLine($"{result}");
*/

// Задача4: Создать метод для создания массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray( int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array [{i + 1}] is {array[i]}");
    }
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/
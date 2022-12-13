// Задача1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
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
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

int GetsumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) 
            sum += array[i];

    return sum;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = GetsumOfNegatives(myArray);
Console.WriteLine("Sum of negative elenents" + result);
*/
// Задача2: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

int[] NegitiveArray(int[] array)
{
    for( int i = 0; i < array.Length; i++ )
    {
        array[i] *= -1;
    }
    return array;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int[] result = NegitiveArray(myArray);
*/
// Задача3: Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
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
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

int Amount(int[] array, int numA, int numB)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i >= numA && i <= numB) count++;
    }
    return count;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine("Input a number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B");
int B = Convert.ToInt32(Console.ReadLine());

int result = Amount(myArray, A, B);

Console.WriteLine(result);
*/

// Задача4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

int[] Work(int[] array)
{
    int size = array.Length/2;
    if(array.Length % 2 != 0) size++;
    int[] newArray = new int[size];
    for(int i = 0, q = array.Length - 1; i <= q; i++, q--)
    {
        newArray[i] = array[i] * array[q];
    }
    return newArray;
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int[] result = Work(myArray);

ShowArray(result);
*/
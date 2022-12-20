// Задача1: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreateRandom2dArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
// Задача1:Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] CreateRandomArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    return array;
}

int[,] myArray = CreateRandomArray();
Show2dArray(myArray); 
*/

// Задача1: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
void Qvart(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i +=2)
        for( int j = 0; j < array.GetLength(1); j += 2)
            array[i,j] *=array[i,j]; 
}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Qvart(myArray);
Show2dArray(myArray);
*/
// Задача1: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0);


int SumDiag(int[,] array)
{
    int sum = 0;
    int minSize = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
    for(int i =0; i < minSize; i++)
        sum = sum +array[i,i];
    return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int result = SumDiag(myArray);
Console.WriteLine(result);
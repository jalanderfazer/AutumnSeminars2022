// ДЗ 7. Как не нужно писать код. Часть 1

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] Create2dArray(int rows, int columns)
{   
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-1000, 1000)/10.0);  // ограничила массив от - 100 до 100
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Show2dArray(Create2dArray(m, n));

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

int[,] Create2dArray(int rows, int columns)
{   
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(-99, 100);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintData(int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
        Console.WriteLine(array[(row - 1),(column - 1)]);
    else
        Console.WriteLine($"There is no element on position {row}, {column}");
}

Console.Write("Input number of rows in new array: ");
int heigth = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in new array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Input number of the row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of the column: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] RandomArray= Create2dArray(heigth, size);
Show2dArray(RandomArray);
PrintData(RandomArray, row, column);
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2dArray(int rows, int columns)
{   
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(-9, 10);  
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] Average(int[,] array)
{
    int rowsNum = array.GetLength(0);
    int columnsNum = array.GetLength(1);
    double[] sum = new double[columnsNum];
    
    for (int i = 0; i < columnsNum; i++)
    {
        for (int j = 0; j < rowsNum; j++)
        {
            sum[i] += array [j, i];
        }
        sum[i] = sum[i] / rowsNum; 
    }
    Console.WriteLine("The arithmetic means of each column are:");
    for (int o = 0; o < columnsNum; o++) 
        Console.Write($"{Math.Round(sum[o],2)} ");
    return sum;
}

Console.Write("Input number of rows in new array: ");
int heigth = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in new array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] RandomArray= Create2dArray(heigth, size);

Show2dArray(RandomArray);
Average(RandomArray);
// ДЗ 8. Как не нужно писать код. Часть 2
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] CreateRandotopdArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Descending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int j2 = j + 1; j2 < array.GetLength(1); j2++)
            {
                if (array[i, j] < array[i, j2])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j2];
                    array[i, j2] = temp;
                }
            }
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandotopdArray(m, n, min, max);

ShowArray(myArray);
Descending(myArray);
ShowArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandotopdArray(int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSum(int[,] array)
{
    int sum = 0;
    int minRow = -10;

    int min = 0;
    for (int j = 0; j < array.GetLength(1); j++) min += array[0, j];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum <= min)
        {
            min = sum;
            minRow = i + 1;
        }
        sum = 0;
    }
    return minRow;
}
Console.Write("Input a number of rows: "); // Надеюсь, прямоугольный массив не подразумевает исключение варианта квадратной матрицы..
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandotopdArray(m, min, max);

ShowArray(myArray);
Console.WriteLine($"{MinSum(myArray)} строка");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandotopdArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Multiplication(int[,] array1, int[,] array2)
{
    int[,] multi = new int[array2.GetLength(0), array1.GetLength(1)];
    if (array1.GetLength(1) != array2.GetLength(0)) Console.WriteLine($"The number of columns in 1 matrix must be equal to the number of rows in 2 matrix!");
    else
    {
        for (int i = 0; i < multi.GetLength(0); i++)
            for (int j = 0; j < multi.GetLength(1); j++)
            {
                multi[i, j] = 0;
                for (int k = 0; k < multi.GetLength(1); k++) 
                    multi[i, j] += array1[i, k] * array2[k, j];
            }
    }
    return multi;
}
Console.Write("Input a number of rows in 1 matrix: ");
int bottom = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns in 1 matrix: ");
int left = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Input a number of rows in 2 matrix: ");
int top = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns in 2 matrix: ");
int right = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = CreateRandotopdArray(bottom, left, min, max);
int[,] secondArray = CreateRandotopdArray(top, right, min, max);

ShowArray(firstArray);
ShowArray(secondArray);

ShowArray(Multiplication(firstArray, secondArray));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int RandomNumber(int[] array,int size)
{
    
    int random = array[new Random().Next(0, size)];
    for (int i = 0; i < size; i ++)
    {
        if (array[i] == random)
        {
            int temp = array[i];
            array[i] = array[size - 1];
            array[size - 1] = temp;
        }
    }
    return random;
}
int[,,] CreateRandom3dArray(int rows, int columns, int layers)
{
    int[,,] array = new int[rows, columns, layers];

    int size = 180;
    if ((rows * columns * layers) > size) Console.WriteLine("Too big matrix for unique two-digit numbers data");
    int nubottom = -99;
    int nutop = 10;
    int[] twodigits = new int[size];
    twodigits[0] = nubottom;
    for (int i = 1; i < size; i++)
    {
        if (i == size/2 + 1) twodigits[i] = nutop;
        else
            if (i <= size/2 || i > (size/2 + 1))
        {
            twodigits[i] = twodigits[i - 1] + 1;
        }
    }

    for (int k = 0; k < array.GetLength(2); k++)
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = RandomNumber(twodigits, size);
                size--;
            }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine($"Layer {k + 1}:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of layers: ");
int o = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(m, n, o);

Show3dArray(myArray);
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralArray(int bottom, int top, int left, int right)
{
    int[,] array = new int[bottom, right];
    int i = 0, j = 0;
    int total = bottom * right; // Всего чисел
    int direction = 0; // Направление движения, 0 - право, 1 - лево, 2 - вниз, 3 - вверх
    for (int num = 0; num < total; num++)
    {
        array[i, j] = num;
        Console.Write(num);
        if (direction == 0) j++;
        else if (direction == 1) j--;
        else if (direction == 2) i++;
        else i--;

        if (direction == 0 && j == right)
        {
            i++;
            direction = 2;
            right--;
        }
        else if (direction == 2 && i == bottom)
        {
            j--;
            direction = 1;
            bottom--;
        }
        else if (direction == 1 && left == j)
        {
            i--;
            direction = 3;
            left++;
        }
        else if (direction == 3 && top == i)
        {
            j++;
            direction = 0;
            top++;
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int left = 0; // Левая граница
Console.Write("Input a number of rows: ");
int right = Convert.ToInt32(Console.ReadLine()); // Правая граница
int bottom = 0; // Нижняя граница
Console.Write("Input a number of columns: ");
int top = Convert.ToInt32(Console.ReadLine()); // Верхняя граница

ShowArray(SpiralArray(bottom, top, left, right));

// ДЗ 5. 
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int[] array, int count)
{
    for( int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.Write($"{array[i]}] -> {count}");
        else Console.Write($"{array[i]}, ");
    }
    
}

int Evens(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    return count; 
}

Console.Write($"Enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] NewArray = CreateRandomArray(n);
int count = Evens(NewArray);
ShowArray(NewArray, count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(-100, 100);  // проверяла без аргументов в Next - вроде тоже считает, но визуально проверять сложнее.
    return array;
}

void ShowArray(int[] array, int sum)
{
    for( int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.Write($"{array[i]}] -> {sum}");
        else Console.Write($"{array[i]}, ");
    }
    
}

int OddSum(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2) sum += array[i];

    return sum; 
}

Console.Write($"Enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] NewArray = CreateRandomArray(n);
int sum = OddSum(NewArray);
ShowArray(NewArray, sum);
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++) array[i] = Convert.ToDouble(new Random().Next(-1000, 1000)/10.0);  // ограничила массив от - 100 до 100
    return array;
}

void ShowArray(double[] array, double diff)
{
    for( int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.Write($"{array[i]}] -> {diff}");
        else Console.Write($"{array[i]}, ");
    }
    
}

double Difference(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];

    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];
    }
    diff = max - min;
    Math.Round(diff,1);
    return diff; 
}

Console.Write($"Enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] NewArray = CreateArray(n);
double diff = Difference(NewArray);
ShowArray(NewArray, diff);


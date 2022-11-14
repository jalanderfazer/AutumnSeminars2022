// ДЗ 4. Функции продолжение

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/* > Комментарий <-----------------------------------------------------------------------------------------------
int Power(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write("Enter first number, please: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number, please: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} to the power of {b} is {Power(a, b)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    return sum;
}
Console.Write("Enter you number, please: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of all digits in number {num} is {SumOfDigits(num)}");
-----------------------------------------------------------------------------------------------> Комментарий */ 
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array)
{
    int length = array.Length;
    for( int i = 0; i < length; i++)
    {
        Console.Write($"Enter {i + 1} number, please: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for( int i = 0; i < length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == 7) Console.Write($"{array[i]}]");
        else if (i < 7 & i > 0) Console.Write($"{array[i]}, ");
        else Console.Write($"You must input 8-digit number");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);

// Не вполне поняла, что подразумевается под "задает массив из 8 элементов", если программа должна была сама рандомайзером - то FillArray можно было бы сделать проще через array[i] = new Random.Next(1,10)), по идее. А еще в примере элементов 5 (в 1) и 3 ( во 2ом). Но сделала на всякий случай 8.
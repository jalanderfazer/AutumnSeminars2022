// ДЗ 1.
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 >= n2)
{
    Console.WriteLine($"Max number = {n1}, min number = {n2}");
    // Эту часть -  , min number = {n2} - лучше убрать, если числа могут быть равны.
}
else 
{
    Console.WriteLine($"Max number = {n2}, min number = {n1}");
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine("Max number is " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = a % 2;

if (result == 0) 
{
    Console.WriteLine($"Yahoo, {a} is even!");
}
else
{
    Console.WriteLine($"{a} is odd :(" );
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. ()

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= N)
{
    if (current % 2 == 0) Console.WriteLine(current);
    current++;
}
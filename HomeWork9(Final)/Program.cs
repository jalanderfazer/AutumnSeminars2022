// ДЗ 9. Как не нужно писать код. Часть 3
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void Numbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) Numbers(n - 1);
}
Console.Write("Input number n, please: ");
int n = Convert.ToInt32(Console.ReadLine());
Numbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Numbers(int m, int n)
{
    if (m < n) 
        return Numbers(m, n - 1) + n;
    else if (m > n)
        return Numbers(m, n + 1) + n;
    else    
        return 0;
    
}
Console.WriteLine("Input number m, please: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number n, please: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(m, n));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint Ackermann(uint m, uint n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Ackermann(m - 1, 1);
    else
      return Ackermann(m - 1, Ackermann(m, n - 1));
}
Console.WriteLine("Input number m, please: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Input number n, please: ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine(Ackermann(m, n));

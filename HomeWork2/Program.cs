// ДЗ 2.
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int number)
{
    int tens = number % 100;
    int ed = tens / 10;
    return ed;
}

Console.Write("Input you 3-digit number pls: ");
int number = Convert.ToInt32(Console.ReadLine());
int ed = 0;

ed = SecondDigit(number);
Console.WriteLine($"The second digit of number {number} is {ed}.");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int number)
{
    int digit3 = -1;
    int num = number;
    if (num < 100)
    {
        return digit3;
    }
    else
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        digit3 = num % 10;
        return digit3;
    }
}

Console.Write("Input a number, please!: ");
int number = Convert.ToInt32(Console.ReadLine());
// int digit3 = -1;

int digit3 = ThirdDigit(number);
if(digit3 == -1)
{
    Console.WriteLine($"There is no third digit in number {number}.");
}
else
{
    Console.WriteLine($"{digit3} is a third digit of {number}.");
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool DayOff(int day)
{
    if(day == 6|| day == 7) return true;
    else return false;
}

Console.Write("Input a day of week number (1,2....7): ");
int day = Convert.ToInt32(Console.ReadLine());

bool res = DayOff(day);
if(res == true)
{
    Console.WriteLine($"The {day} day of a week is a day off!");
}
else
{
    Console.WriteLine($"The {day} day of a week is a working day.");
}
// ДЗ 3.
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*  
// bool Palindrome(string number) - это комментарий в комментарии, не стала удалять этот кусок кода. Пыталась решить задачу для общего случая (без заданной длины строки), но все время выдавало ошибку "Не все пути к коду возвращают значение" к этой функции. Так и не поняла, в каком направлении нужно править код, сдалась и написала без цикла :(
// {
//     int length = number.Length;
//     // int currentPos = 0;
//     // int PalindromePos = length - 1;
//     for (int i = 0; i < (length / 2); i++)
//     {
//         // currentPos = i;
//         // PalindromePos = length - i - 1;
//         if(number[i] != number[length - i - 1]) return false;
//         else return true;
//     }

// }

bool Palindrome(string number)
{
    if(number[0] != number[4]) return false;
    else if(number[1] != number[3]) return false;
    else return true;
}

Console.Write("Input a number: ");
string number = Console.ReadLine();
bool res = Palindrome(number);

if(res == true) Console.WriteLine($"Yes, {number} is a palindrome!");
else Console.WriteLine($"No, {number} is not a palindrome.");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.Write("Input x coord for a 1 point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y coord for a 1 point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z coord for a 1 point: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x coord for a 2 point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y coord for a 2 point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z coord for a 2 point: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"The distance between A and B is {dist}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cubed(int n)
{
    int count = n;
    for(int i = 1;i <= count; i++)
    {
       Console.WriteLine(Math.Pow(i,3) + " ");
    }
}

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Cubed(n);
/*
Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

int PrintNumbers(int M, int N)
{
    if (M > N)
    {
        Console.Write($"{N}, ");
        if (M == N)
        {
            return (N);
        }

        return PrintNumbers(M, N + 1);
    }
    Console.Write($"{M}, ");
    if (M == N)
    {
        return (M);
    }

    return PrintNumbers(M + 1, N);
}

Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine()!);
PrintNumbers(M, N);
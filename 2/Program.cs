﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (N > 999)
    {
        N/=10;
    }
System.Console.WriteLine(N%10);
}
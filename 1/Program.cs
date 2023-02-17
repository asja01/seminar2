// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if(N>99 && N<1000)
{
    System.Console.WriteLine(N%100/10);

}
else
{
    Console.WriteLine("Введено не трехзначное число");

}
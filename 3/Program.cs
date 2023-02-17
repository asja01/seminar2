// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if(N>0 && N<6)
{
    System.Console.WriteLine("нет");

}
else if (N>5 && N<8)

{
System.Console.WriteLine("да");
}
else
{
    Console.WriteLine("Не день недели");

}
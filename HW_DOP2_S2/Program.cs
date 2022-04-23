// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(Math.Pow(numberA, 2) == numberB || Math.Pow(numberB, 2) == numberA)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}

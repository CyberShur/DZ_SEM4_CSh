// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: "); 
string Input = Console.ReadLine();

int sum = 0;

for (int count = 0; count < Input.Length; count++)
{
    sum = sum + int.Parse(Input[count].ToString());
}

Console.WriteLine($"Сумма цифр числа {Input} равна {sum}");
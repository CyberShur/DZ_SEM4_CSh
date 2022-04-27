// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Поправка: на семинаре дал добро на заволнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, а программа 
// превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Вы ввели массив: "); 

WriteArray(array);

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
        Console.Write("[" + array[i] + ", ");
        }
        else if (array.Length - 1 - i == 0)
        {
            Console.Write(array[i] + "]");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine();
}

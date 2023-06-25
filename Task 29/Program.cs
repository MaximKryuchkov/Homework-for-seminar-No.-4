// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Method1(string message)
{
    System.Console.Write("Введите число: ");
    string readInput = System.Console.ReadLine()!;
    int result = int.Parse(readInput);
    return result;
}

int Array(int Length, int min, int max)
{
    int[] array = new int[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}, ");
    System.Console.Write("]");
}

int lenght = Method1("Длинна массива: ");
int min = Method1("Начало массива: ");
int max = Method1("Конец массива: ");
int[] array = Array(lenght, min, max);
PrintArray(array);
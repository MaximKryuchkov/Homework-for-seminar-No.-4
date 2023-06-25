// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Method1(string message)
{
    System.Console.Write("Введите число: ");
    string readInput = System.Console.ReadLine()!;
    int result = int.Parse(readInput);
    return result;
}

int Method2(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int num = Method1("Введите число: ");
System.Console.WriteLine($"Сумма цифр в ведённом числе {num} = {Method2(num)}");
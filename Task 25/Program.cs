// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Method(string message)
{
    System.Console.Write("Введите число: ");
    string readInput = System.Console.ReadLine()!;
    int result = int.Parse(readInput);
    return result;
}

int Power(int numA, int numB)
{
    int power = 1;
    for (int i = 0; i < numB; i++)
    {
        power *= numA;
    }
    return power;
}

int numA = Method("Введите Первое число: ");
int numB = Method("Введите Второе число: ");

System.Console.WriteLine($"Число {numA} в степени {numB} равно {Power(numA, numB)}");
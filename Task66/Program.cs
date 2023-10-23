// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CountSumOfNaturalNumBetween(int min, int max)
{
    int currentSum = max;
    if (max > min)
    {
        currentSum += CountSumOfNaturalNumBetween(min, max-1);
    }
    return currentSum;
}

Console.Write("Введите натуральное число M: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int maximum = Convert.ToInt32(Console.ReadLine());
if (maximum < minimum) Console.WriteLine("Некорректный ввод");
else 
{
    int sum = CountSumOfNaturalNumBetween(minimum, maximum);
    Console.WriteLine($"Сумма натуральных чисел в заданном промежутке: {sum}");
}
﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNaturalNumbersTo(int number)
{
    Console.Write($"{number} ");
    if (number == 1) return;
    PrintNaturalNumbersTo(number - 1);
}

Console.Write("Введите натуральное число N: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());
if (naturalNumber < 1) Console.WriteLine("Некорректный ввод");
else PrintNaturalNumbersTo(naturalNumber);
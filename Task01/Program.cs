﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber * secondNumber == firstNumber)
    Console.WriteLine($"Первое число = {firstNumber}, Второе число = {secondNumber} -> да");
else
    Console.WriteLine($"Первое число = {firstNumber}, Второе число = {secondNumber} -> нет");
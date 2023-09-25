// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetSecondDigit(int num)
{
    return (num / 10) % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000) Console.WriteLine($"Вторая цифра: {GetSecondDigit(number)}");
else Console.Write("Некорректный ввод");
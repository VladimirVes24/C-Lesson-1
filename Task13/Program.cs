// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetThirdDigit(int num)
{
    num = Math.Abs(num);
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number > -100) Console.WriteLine($"{number} -> Третьей цифры нет");
else Console.WriteLine($"{number} -> {GetThirdDigit(number)}");

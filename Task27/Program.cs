// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetDigitsSum(int num)
{
    int sum = 0;
    num = Math.Abs(num);
    while (num > 9)
    {
        sum += num % 10;
        num = num / 10;
    }
    if (num < 9) sum += num;
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = GetDigitsSum(number);
Console.WriteLine($"Сумма цифр: {res}");
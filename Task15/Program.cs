// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool CheckWeekend(int day)
{
    if (day == 6 || day == 7) return true;
    else return false;
}

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7) Console.WriteLine("Некорретный ввод");
else if (CheckWeekend(day)) Console.WriteLine("Да");
else Console.WriteLine("Нет");


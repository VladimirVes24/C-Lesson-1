// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool IsOneSquareOfOther(int firstPar, int secondPar)
{
    return firstPar*firstPar == secondPar || secondPar*secondPar == firstPar;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsOneSquareOfOther(firstNumber, secondNumber);
Console.WriteLine(isSquare ? "да" : "нет");
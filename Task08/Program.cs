// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
//if (N == 1) Console.WriteLine("1 -> _ "); - из задания неясно, что выводить в данном случае, оставил пустое место
if (N > 0)
{
    Console.Write($"{N} -> ");
    for (int i = 2; i <=N; i += 2)
    {
        Console.Write($"{i} ");
    }
}
else Console.WriteLine("Некорректный ввод");
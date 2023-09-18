/* Напишите программу:
1. принятие числа на вход 
2. ввычисление квадрата
3. вывод результата
Например:
4 -> 16
-3 -> 9
-7 -> 49 */

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqrt = number * number;
Console.WriteLine("Квадрат числа равен: " + sqrt);


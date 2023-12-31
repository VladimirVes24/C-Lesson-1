﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


uint AkkermanFunc(uint m, uint n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkermanFunc(m - 1, 1);
    else
      return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.WriteLine(AkkermanFunc(3,2));
Console.WriteLine(AkkermanFunc(2,3));
Console.WriteLine(AkkermanFunc(2,4));
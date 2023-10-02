// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int length)
{
    int[] array = new int[length]; 
    for (int i = 0; i < length; ++i)
    {
        Console.Write($"Введите {i} элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; ++i)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length - 1)) Console.Write(", ");
        else Console.WriteLine("]");
    }
    
}

int[] ar = CreateArray(8);
PrintArray(ar);
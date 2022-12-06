// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] 


Console.Clear();
int [] arr = new int [8];

void FulfillArray (int[] array)
{
    int i = 1;
    while (i<=array.Length)
    {
    Console.Write($"{new Random().Next(101)} ");
    i++;
    }
}

FulfillArray(arr);


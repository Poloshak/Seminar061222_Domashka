// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] 


Console.Clear();
int[] arr = FulfillArray(8);
Console.WriteLine($"[{String.Join(",", arr)}]");

int[] FulfillArray (int size)
{
    int []array = new int [size];
    int i = 0;
    while (i<size)
    {
    array[i] = new Random().Next(101);
    i++;
    }
    return array;
}




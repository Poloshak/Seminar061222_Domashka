// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetNumDegree (A)}");

int GetNumDegree (int result)
{   
    int i = 1;
    result = A;
    while(i<B)
    {
        result = result*A;
        i++;
    }
    return result;
}

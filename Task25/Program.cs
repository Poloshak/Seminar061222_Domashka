﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int GetNumDegree (int baza, int degree)
{   
    int i = 1;
    int result = baza;
    while(i<degree)
    {
        result = result*baza;
        i++;
    }
    return result;
}
Console.Write("Введите число ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetNumDegree (A,B)}");


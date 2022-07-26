﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.WriteLine("Print m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Print n: ");
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m, n];
Random yuy = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = yuy.Next(-10, 10);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}


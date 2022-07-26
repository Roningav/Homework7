/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine("Print m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Print n: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++) // Печать массива
{
    Random yuy = new Random();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = yuy.Next(1, 10);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
for ( int j = 0; j < n; j++) // Нахождение среднего арифметического
{   int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + matrix[i, j];
    }
    int result = sum/m;
    Console.WriteLine($"Среднее арифметическое столбца {j}: {(double)sum / m}");
}

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int GetNumber(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) // int выводиm
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }

    return result;
}


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random yuy = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        matrix[i, j] = yuy.Next(1, 5);
        }
    }
    return matrix;
}
int number = GetNumber("Print your desired number: ");
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FindNumber(int[,] matrix) //проверка на наличие числа в двумерном массиве
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"Число {number} находится на позиции [{i}, {j}].");
            }
        }
    }
}
int m = GetNumber("Print m: ");
int n = GetNumber("Print n: ");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
FindNumber(matrix);


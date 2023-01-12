// Задача 55.
// Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа
// должна вывести сообщение для пользователя.



// Вариант 2
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
PrintArray(Transponation(array));

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Transponation(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(1), inArray.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = inArray[j, i];
        }
    }
    return result;
}

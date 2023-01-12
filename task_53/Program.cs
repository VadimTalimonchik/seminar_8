// Задача 53.
// Задайте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива.

// int[,] CreateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(0, 11);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0}	", array[i, j]);
//         }
//         Console.WriteLine(" ");
//     }
// }
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество колонок: ");
// int columns = int.Parse(Console.ReadLine()!);
// Console.WriteLine(" ");
// int[,] array = new int[rows, columns];
// array = CreateArray(rows, columns);
// Console.WriteLine(" ");
// PrintArray(array);
// Console.WriteLine(" ");


// int[,] TransportRows(int[,] array)
// {
//     int temp = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         temp = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
//     return array;
// }

// PrintArray(TransportRows(array));



// Второй вариант

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
PrintArray(GetArrayChangeRows(array));

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

int[,] GetArrayChangeRows(int[,] inArray) // создаем второй массив
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == 0) // первую строчку меняем с последней
            {
                result[i, j] = inArray[inArray.GetLength(0) - 1, j];
            }
            else if (i == inArray.GetLength(0) - 1) // последнюю строчку меняем с первой
            {
                result[i, j] = inArray[0, j];
            }
            else
            {
                result[i, j] = inArray[i, j];
            }
        }
    }
    return result;
}

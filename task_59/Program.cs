// Задача 59.
// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

// int CoordinatesMin(int[,] array)
// {
//     int min = array[0, 0];
//     int k = 0;
//     int p = 0;
//     int t = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 p = i;
//                 t = j;
//             }
//         }
//     }
//     Console.WriteLine("MinElement" + " " + min);

//     k = 10 * p + t;
//     return k;
// }
// int k = CoordinatesMin(array);
// int rowMin = k / 10;
// int columnMin = k % 10;
// // PrintArray(DeleteColumn(array, columnMin));
// PrintArray(DeleteRow(DeleteColumn(array, columnMin), rowMin));

// int[,] DeleteColumn(int[,] array, int columnMin)

// {
//     int[,] deletedColumn = new int[array.GetLength(0), array.GetLength(1) - 1];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             if (j < columnMin)
//             {
//                 deletedColumn[i, j] = array[i, j];
//             }
//             if (j >= columnMin)
//             {
//                 deletedColumn[i, j] = array[i, j + 1];
//             }
//         }
//     }
//     return deletedColumn;
// }


// int[,] DeleteRow(int[,] array, int rowMin)

// {
//     int[,] deletedRow = new int[array.GetLength(0)-1, array.GetLength(1)];

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             if (i < rowMin)
//             {
//                 deletedRow[i, j] = array[i, j];
//             }
//             if (j >= rowMin)
//             {
//                 deletedRow[i, j] = array[i + 1, j];
//             }
//         }
//     }
//     return deletedRow;
// }

// Вариант 2
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
PrintArray(NewArray(array, FindMinElement(array)));

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
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[] FindMinElement(int[,] Matrix) // находим минимальный элемент массива и его индексы
{
    int min = Matrix[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            if (Matrix[i, j] < min)
            {
                minI = i;
                minJ = j;
                min = Matrix[i, j];
            }
        }
    }
    int[] Temporary = { minI, minJ }; // координаты строчки и столбца
    return Temporary;
}

int[,] NewArray(int[,] OriginalArray, int[] Coordinati)
{
    int newrow = 0;
    int newcolumn = 0;
    int[,] result = new int[OriginalArray.GetLength(0) - 1, OriginalArray.GetLength(1) - 1];
    for (int i = 0; i < OriginalArray.GetLength(0); i++)
    {
        if (i != Coordinati[0])
        {
            for (int j = 0; j < OriginalArray.GetLength(1); j++)
            {
                if (j != Coordinati[1])
                {
                    result[newrow, newcolumn] = OriginalArray[i, j];
                    newcolumn++;
                }
            }
            newrow++;
            newcolumn = 0;
        }
    }
    return result;
}

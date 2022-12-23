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

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}	", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество колонок: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");

int CoordinatesMin(int[,] array)
{
    int min = array[0, 0];
    int k = 0;
    int p = 0;
    int t = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                p = i;
                t = j;
            }
        }
    }
    Console.WriteLine("MinElement" + " " + min);

    k = 10 * p + t;
    return k;
}
int k = CoordinatesMin(array);
int rowMin = k / 10;
int columnMin = k % 10;
// PrintArray(DeleteColumn(array, columnMin));
PrintArray(DeleteRow(DeleteColumn(array, columnMin), rowMin));

int[,] DeleteColumn(int[,] array, int columnMin)

{
    int[,] deletedColumn = new int[array.GetLength(0), array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (j < columnMin)
            {
                deletedColumn[i, j] = array[i, j];
            }
            if (j >= columnMin)
            {
                deletedColumn[i, j] = array[i, j + 1];
            }
        }
    }
    return deletedColumn;
}


int[,] DeleteRow(int[,] array, int rowMin)

{
    int[,] deletedRow = new int[array.GetLength(0)-1, array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            if (i < rowMin)
            {
                deletedRow[i, j] = array[i, j];
            }
            if (j >= rowMin)
            {
                deletedRow[i, j] = array[i + 1, j];
            }
        }
    }
    return deletedRow;
}


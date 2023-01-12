// Задача 57.
// Составить частотный словарь элементов двумерного массива. Частотный словарь
// содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных: { 1, 9, 9, 0, 2, 8, 0, 9 }
// Частотный массив:   0 встречается 2 раза 
//                     1 встречается 1 раз 
//                     2 встречается 1 раз 
//                     8 встречается 1 раз 
//                     9 встречается 3 раза
// Набор данных:   1, 2, 3 
//                 4, 6, 1 
//                 2, 1, 6
// Частотный массив:   1 встречается 3 раза 
//                     2 встречается 2 раз 
//                     3 встречается 1 раз 
//                     4 встречается 1 раз 
//                     6 встречается 2 раза

// int[,] CreateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
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

// void DigitCounter(int[,] array)
// {
//     int counter = 0;
//     for (int digit = 0; digit < 10; digit++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] == digit) counter++;
//             }
//         }
//         if (counter == 2 || counter == 3 || counter == 4 )
//         {
//             Console.WriteLine($"Цифра {digit} встретилась {counter} раза");
//         }
//         else
//         {
//             Console.WriteLine($"Цифра {digit} встретилась {counter} раз");
//         }
//         counter = 0;
//     }
// }

// DigitCounter(array);


// // Вариант 2 - недоделанный

// int[,] CreateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
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

// void PrintOneDimArray(int[] array);
// {
//     for (int j = 0; j < length; j++)
//     {
//         Console.Write(array[j]);
//     }
// }

// Console.Write("Enter the number or rows...");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the number or columns..");
// int columns = int.Parse(Console.ReadLine()!);
// Console.WriteLine(" ");
// int[,] array = new int[rows, columns];
// array = CreateArray(rows, columns);
// Console.WriteLine(" ");
// PrintArray(array);
// Console.WriteLine(" ");


// int[] OneDimensionArray (int[,] array)
// {
//     int element = 0;
//     int [] OneDimensionArray = new int [(array.GetLength(0))*(array.GetLength(1))];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             element = array[i,j];
//             OneDimensionArray = element;
//         }
//     }
//     return OneDimensionArray;
// }

// PrintOneDimArray(OneDimensionArray(array));



// Вариант 3

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(
    SortArray(
        CreateSingleArray(array)));
Console.WriteLine();


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

int[] CreateSingleArray(int[,] inArray)
{
    int k = 0;
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k] = inArray[i, j];
            Console.Write(result[k] + " ");
            k++;
        }
    }
    Console.WriteLine();
    return result;
}

int[] SortArray(int[] inArray)
{
    Array.Sort(inArray);
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.WriteLine();
    return inArray;
}

void FrequencyDictionary(int[] newarray)
{
    int count = 1;
    int solveelement = newarray[0];
    for (int i = 1; i < newarray.Length; i++)
    {
        if (solveelement == newarray[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"число {solveelement} встречается {count} раз ");
            solveelement = newarray[i];
            count = 1;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine($"число {solveelement} встречается {count} раз ");
}

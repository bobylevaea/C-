// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
//             array[i, j] = Math.Round(array[i, j], 1);
//         }
//     return array;
// }

// void Show2dDoubleArray(double[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dDoubleArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindElement(int[,] array, int row, int column)
// {
//     if (row < array.GetLength(0) && column < array.GetLength(1)) return array[row, column];
//     else return -1;
// }

// int[,] myArray = CreateRandom2dArray(4, 5, 0, 30);
// Console.WriteLine("Созданная матрица:");
// Show2dArray(myArray);
// Console.Write("Введите номер строки элемента: ");
// int numRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца элемента: ");
// int numColumn = Convert.ToInt32(Console.ReadLine());
// int element = FindElement(myArray, numRow-1, numColumn-1); // пользователь не знает, что индексация начинается с 0, от введенного пользователем значения отнимаем 1

// if (element != -1)
// Console.WriteLine($"Значение элемента на {numRow} строке, в {numColumn} столбце -> {element}");
// else
// Console.WriteLine("Такого элемента в массиве нет");


// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double AvgColumn(int[,] array, int column)
{
    double avg = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avg += array[i, column];
    }
    avg /= array.GetLength(0);
    return avg;
}

double[] AvgAllColumns(int[,] array)
{
    double[] avgColumns = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        avgColumns[j] = AvgColumn(array, j);
    }
    return avgColumns;
}

int[,] myArray = CreateRandom2dArray(4, 5, 0, 30);
Console.WriteLine("Созданная матрица:");
Show2dArray(myArray);
double[] avgAllColumns = AvgAllColumns(myArray);
Console.Write($"Среднее арифметическое каждого столбца: ");
ShowDoubleArray(avgAllColumns);

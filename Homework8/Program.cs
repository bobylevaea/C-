// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// ================================================================================

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

// void SortRowsDescending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int maxIndex = j;

//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, maxIndex])
//                     maxIndex = k;
//             }

//             if (maxIndex != j)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[i, maxIndex];
//                 array[i, maxIndex] = temp;
//             }
//         }
//     }
// }

// int[,] myArray = CreateRandom2dArray(3, 4, 0, 30);
// Console.WriteLine("Созданная матрица:");
// Show2dArray(myArray);
// SortRowsDescending(myArray);
// Console.WriteLine("Отсортированная матрица:");
// Show2dArray(myArray);

// ============================================================================================

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// =========================================================================

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

// int[] SumRows(int[,] array)
// {
//     int[] rowSums = new int[array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         rowSums[i] = sum;
//     }

//     return rowSums;
// }

// int FindMinIndex(int[] array)
// {
//     int minIndex = 0;

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < array[minIndex])
//             minIndex = i;
//     }

//     return minIndex;
// }

// int[,] myArray = CreateRandom2dArray(4, 4, 0, 9);
// Console.WriteLine("Созданная матрица:");
// Show2dArray(myArray);
// int[] rowSums = SumRows(myArray);
// int result = FindMinIndex(rowSums);
// Console.Write($"Наименьшая сумма элементов в строке: {result+1}");

// =========================================================================

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

// int[,] MultiplyMatrices(int[,] array1, int[,] array2)
// {
//     int rows1 = array1.GetLength(0);
//     int cols1 = array1.GetLength(1);
//     int rows2 = array2.GetLength(0);
//     int cols2 = array2.GetLength(1);

//     if (cols1 != rows2)
//         Console.WriteLine("Несовместимые размеры матриц");

//     int[,] result = new int[rows1, cols2];

//     for (int i = 0; i < rows1; i++)
//     {
//         for (int j = 0; j < cols2; j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < cols1; k++)
//                 sum += array1[i, k] * array2[k, j];

//             result[i, j] = sum;
//         }
//     }

//     return result;
// }

// int[,] myArray1 = CreateRandom2dArray(2, 2, 1, 9);
// Console.WriteLine("Созданная первая матрица:");
// Show2dArray(myArray1);

// int[,] myArray2 = CreateRandom2dArray(2, 2, 1, 9);
// Console.WriteLine("Созданная вторая матрица:");
// Show2dArray(myArray2);

// int[,] result = MultiplyMatrices(myArray1, myArray2);
// Console.WriteLine($"Итоговая матрица: ");
// Show2dArray(result);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// =========================================================================

// int GetUniqNumber(int[] array)
// {
//     int nextNumber;
//     do nextNumber = new Random().Next(10, 100);
//     while (array[nextNumber] != 0);
//     array[nextNumber] = 1;
//     return nextNumber;
// }

// int[,,] Create3dArray(int rows, int columns, int layers, int[] array)
// {
//     int[,,] returnArray = new int[rows, columns, layers];

//     if (rows * columns * layers < 90)
//     {
//         for (int i = 0; i < returnArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < returnArray.GetLength(1); j++)
//             {
//                 for (int k = 0; k < returnArray.GetLength(2); k++)
//                     returnArray[i, j, k] = GetUniqNumber(array);
//             }
//         }
//     }
//     else
//         Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
//     return returnArray;
// }

// void Show3dArray(int[,,] array3d)
// {
//     for (int i = 0; i < array3d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3d.GetLength(2); k++)
//                 Console.Write($"[{i},{j},{k}] {array3d[i, j, k]} ");
//             Console.WriteLine();
//         }
//     }
// }

// Console.WriteLine();
// int[] myArray = new int[100];
// int[,,] array3d = Create3dArray(2, 2, 2, myArray);
// Show3dArray(array3d);

// =========================================================================
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] FillArrayInSpiral(int rows, int columns)
// {
//     int[,] spiralArray = new int[rows, columns];

//     int i = 0;
//     int j = 0;

//     int RightDirect = 1, DownDirect = 0;
//     int direct = 0, sideLength = columns;

//     for (int item = 0; item < spiralArray.Length; item++)
//     {
//         spiralArray[i, j] = item + 1;

//         --sideLength;
//         if (sideLength == 0)
//         {
//             sideLength = columns * (direct % 2) + rows * ((direct + 1) % 2) - (direct / 2 - 1) - 2;

//             int temp = RightDirect;
//             RightDirect = -DownDirect;
//             DownDirect = temp;
//             direct++;
//         }
//         i += DownDirect;
//         j += RightDirect;
//     }

//     return spiralArray;
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

// int[,] myArray = FillArrayInSpiral(4, 4);
// Console.WriteLine();
// Show2dArray(myArray);



// def fill_array_in_spiral(rows, columns):
//     spiral_array = [[0] * columns for _ in range(rows)]

//     i, j = 0, 0
//     right_direct, down_direct = 1, 0
//     direct = 0
//     side_length = columns

//     for item in range(rows * columns):
//         spiral_array[i][j] = item + 1

//         side_length -= 1
//         if side_length == 0:
//             side_length = columns * (direct % 2) + rows * ((direct + 1) % 2) - (direct // 2 - 1) - 2

//             temp = right_direct
//             right_direct = -down_direct
//             down_direct = temp
//             direct += 1

//         i += down_direct
//         j += right_direct

//     return spiral_array

// def show_2d_array(array):
//     for row in array:
//         for element in row:
//             print(element, end=" ")
//         print()
//     print()

// my_array = fill_array_in_spiral(4, 4)
// show_2d_array(my_array)

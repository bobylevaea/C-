// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// int SumEvenNumbers(int[] array)
// {
//     int sumEven = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) sumEven++;
//     }
//     return sumEven;
// }

// int[] array = CreateRandomArray(10, 100, 999);
// ShowArray(array);
// int sum = SumEvenNumbers(array);
// Console.WriteLine($"Количество четных чисел = {sum}");


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// int SumOddNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//         sum += array[i];
//     return sum;
// }

// int[] array = CreateRandomArray(4, 1, 15);
// ShowArray(array);
// int result = SumOddNumbers(array);
// Console.WriteLine($"Сумма всех элементов на нечетной позиции = {result}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateRandomArray(int size, double minValue, double maxValue)
// {
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
//         array[i] = Math.Round(array[i], 2);
//     }   
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// double DiffMaxMin(double[] array)
// {
//     double max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//     }
//     double min = max;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//     }
//     double result = max - min;
//     result = Math.Round(result, 2);
//     return result;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// double max = Convert.ToDouble(Console.ReadLine());
// double[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// double res = DiffMaxMin(array);
// Console.WriteLine($"Разница max и min элементов = {res}");


    static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        string[] inputArray = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        string[] filteredArray = FilterArray(inputArray);

        Console.WriteLine("Исходный массив:");
        PrintArray(inputArray);

        Console.WriteLine("Результирующий массив:");
        PrintArray(filteredArray);
    }







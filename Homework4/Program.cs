// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Power(int num, int exponent)
// {
//     int power = 1;
//     for(int i = 0; i < exponent; i++)
//         power *= num;
    
//     return power;
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input exponent: ");
// int exp = Convert.ToInt32(Console.ReadLine());
// int rezult = Power(number, exp);

// if(exp > 0)
//     Console.Write($"Число {number} в степени {exp} равно {rezult}");
// else
//     Console.Write("Показатель не должен быть меньше нуля");

// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumAllDigit(int num)
// {
//     int rez = 0;
//         while (num > 0)
//         {
//             rez += num % 10;
//             num = num / 10;
//         }
//     return rez;
// }
// Console.WriteLine("Please, enter digit");
// int digit = Convert.ToInt32(Console.ReadLine());
// int rezult = SumAllDigit(digit);
// Console.Write($"Сумма чисел цифры {digit} равно {rezult}");

// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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
// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

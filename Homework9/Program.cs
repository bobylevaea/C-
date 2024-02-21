// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// ============================================================================================

// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) ShowNums(num - 1);
// }

// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// ShowNums(number);

// ============================================================================================
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// ============================================================================================

// int SumNaturalNumbers(int start, int end)
// {
//     if (start > end) return 0;
//     return start + SumNaturalNumbers(start + 1, end);
// }

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int sum = SumNaturalNumbers(numberA, numberB);
// Console.WriteLine($"Сумма чисел между {numberA} и {numberB} = {sum}");

// ============================================================================================
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// ============================================================================================

// int Ackermann(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) 
//         return Ackermann(m - 1, 1);
//     else
//         return Ackermann(m - 1, Ackermann(m, n - 1));
// }

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result = Ackermann(numberA, numberB);
// Console.WriteLine($"А({numberA},{numberB}) = {result}");
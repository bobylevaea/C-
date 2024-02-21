// // Homework 2


// Task 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int CutNumber(int num)
//     {
//     int units = num % 100;

//     int result = units / 10;
//     return result;
//     }

// Console.WriteLine("Input number, please: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int shortNum = CutNumber(num);

// if (num > 99 && num < 1000)
//     Console.WriteLine($"New version of {num} is {shortNum}");
// else
//     Console.WriteLine("You entered a wrong digit");


// // Task 13: Напишите программу, которая выводит третью цифру заданного 
// // числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6

// // int ThirdDigit(int num)
// // {
// //     while (num > 999)
// //     {
// //         num /= 10;
// //     }
// //     return num % 10; 
// // }

// // Console.WriteLine("Input digit, please: ");
// // int num = Convert.ToInt32(Console.ReadLine());
// // int thirdRezult = ThirdDigit(num);

// // if (num > 99)
// //     Console.WriteLine($"The third digit is {thirdRezult}");
// // else
// //     Console.WriteLine("The third digit is absent ");


// // Task 15: Напишите программу, которая принимает на вход цифру, 
// // обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// // 7 -> да
// // 1 -> нет

// bool WeekEnd(int num)
// {
//     if (num > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValidDay(int num)
// {
//     if (num > 0 && num <= 7)
//     { 
//         return true;
//     }
//     Console.WriteLine("You entered a wrong day");
//     return false;
// }

// Console.WriteLine("Input digit, please: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (ValidDay(num))
// {    
//     if (WeekEnd(num))
//     {
//         Console.WriteLine("yes");
//     }
//     else
//     {
//         Console.WriteLine("no");
//     }
// }



// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// bool IsPalindrome(int num)
// {
// int n = num;
// int rev = 0;
//     while (n>0)
//     {
//         int r = n % 10;
//         rev = rev * 10 + r;
//         n = n / 10;
//     }
// return (num == rev);
// }
// Console.WriteLine("Please, enter digit");
// int digit = Convert.ToInt32(Console.ReadLine());

// if (IsPalindrome(digit))
// Console.WriteLine("Палиндром");
// else
// Console.WriteLine("Не является палиндромом");

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// double Gipot(double x1, double y1, double z1,double x2, double y2, double z2)
// {
// double distX = x2-x1;
// double distY = y2-y1;
// double distZ = z2-z1;
// double result = Math.Sqrt(distX*distX + distY*distY + distZ*distZ);
// return result;
// }
// Console.Write ("Введите значение x1 - ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите значение y1 - ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите значение z1 - ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите значение x2 - ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите значение y2 - ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите значение z2 - ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double rez = Math.Round(Gipot(x1,y1,z1,x2,y2,z2),2);

// Console.Write ($"Расстояние между точками составляет - {rez}");



// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// void TabKub(int N)
// {
//     int count = 1;
//     int power = 3;
//     while (count<=N)
//     {
//         Console.WriteLine ($"Куб {count} составляет - {Math.Pow(count, power)}");
//         count++;
//     }
// }
// Console.WriteLine("Please, enter digit");
// int digit = Convert.ToInt32(Console.ReadLine());
// TabKub(digit);
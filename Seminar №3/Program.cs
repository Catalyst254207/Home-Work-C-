// Задача со звездочкой. Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// void Average(int x1, int x2, int y1, int y2)
// {
//     int x3 = x2 - x1;
//     int y3 = y2 - y1;
//     Console.WriteLine("Answer is " + Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2)));
// }

// Обозначаем функцию void. Внутри функции находим длинну вектора. Сначала из конечных координат вычетаем начальные.
// Затем полученные значения берем в квадрат и от их суммы берем квадратный корень.

// Console.WriteLine("Enter num for x1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num for y1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num for x2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num for y2:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Average(x1, x2, y1, y2);

// Запрашиваем у пользователя входнные данные и запускаем функцию.

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// void Average(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     int x3 = x2 - x1;
//     int y3 = y2 - y1;
//     int z3 = z2 - z1;
//     Console.WriteLine("Answer is " + (Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(z3, 2))));
// }

// Console.WriteLine("Enter num for x1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num for y1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num for z1:");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter num for x2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num for y2:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num for z2:");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Average(x1, x2, y1, y2, z1, z2);

// Задача идентична предыдущей, только добавляется 3 ось Z.

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Enter your number: ");
// string? number = Console.ReadLine();

// Запрашиваем у пользователя входные данные - в данном случаи число и рассматриваем его как текст.

// void Check(string number){
  
// if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine("Your number is a palindrome.");
// }
// else Console.WriteLine("Your number is not a palindrome");
// }

// Обозначаем функцию - если 1 и 5 числа, а также 2 и 4 равны - значит введеное число является палиндромом.

// if (number!.Length == 5){
// Check(number);}

// else Console.WriteLine("Not a correct number");

// Вводим условие - число должно быть пятизначным. Запускаем функцию.

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.

// Решение №1

// void Sque(int n)
// {
//   for(int i = 0; i <= n; i++)
//   {
//    Console.Write(i*i*i + " ");
//   }
// }

// Обозначаем функцию. В функции делаем цикл for.

// Console.WriteLine("Enter your number:");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n<=0) Console.WriteLine("Not a correct number");
// Sque(n);

// Запрашиваем у пользователя входные данные и запускаем функцию. Данное решение простое.

// Решение №2

// void Sque(int n)
// {
//   for(int i = 0; i <= n; i++)
//   {
//    Console.Write(Math.Pow(i, 3) + " ");
//   }
// }

// Console.WriteLine("Enter your number:");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n<=0) Console.WriteLine("Not a correct number");
// Sque(n);

// Данное решение отличается от предыдущего только наличием функции Math.Pow.

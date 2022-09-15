// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void Degree(int a, int b){
//     // Обозначаем функцию void.
// int c = a;  
//   for (int i = 1; i < b; i++){
//     c = c * a;
//   }
// // Описываем цикл void.  
// Console.WriteLine("Answer is : " + c);  
// // Выводим ответ.
// }
// Console.WriteLine("Enter number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Degree(a, b);
// // Запрашиваем входные данные у пользователя и запускаем функцию.

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Enter your number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// // Запрашиваем вводные данные у пользователя.
//   int SumAllNum(int n){
// // Обозначаем функцию SumAllNum.    
//     int c = Convert.ToString(n).Length;
//     int a = 0;
//     int b = 0;
// // Вводим переменные, одна из которых обозначает длинну строки (конвертируем наше число в строку).
// // Создаем цикл.
//     for (int i = 0; i < c; i++){
//       a = n - n % 10;
//       b = b + (n - a);
//       n = n / 10;
//     }
//    return b;
// }
// int sumAllNum = SumAllNum(n);
// Console.WriteLine($"The sum of all digits in from the number {n} is: " + sumAllNum); 
// // Выводим ответ.

// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

// Не смог выполнить первую часть задачи.

// int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
// void Print(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
// }
// Print(array);


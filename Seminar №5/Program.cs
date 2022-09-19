// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] array = new int[10];
// // Создаем массив с количеством элементов 10.
// int[] CreateRandomArray(int [] array, int min, int max){

//     for(int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }
// // Создаем функцию, которая наполнит массив рандомными числами.

// void ShowArray(int[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// // Создаем функцию, которая выведет пользователю массив.
// void SumEvenNumber(int[] array){
//     int coutn = 0;
//     for(int i = 0; i < array.Length; i++){
//        if (array[i]%2==1) coutn++;
//     }
//     Console.WriteLine($"The number of even numbers in the array is {coutn}.");
// }
// // Создаем функцию, которая будет проверять каждый элемент массива на четность и считать количество четных чисел в массиве.
// CreateRandomArray(array, 100, 1000);
// ShowArray(array);
// SumEvenNumber(array);
// // Даем вводные данные и запускаем все функции.

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] numbers = new int[10];
// // Создаем массив с количеством элементов 10.
// int[] NewRandomArray(int [] numbers, int min, int max){

//     for(int i = 0; i < numbers.Length; i++){
//         numbers[i] = new Random().Next(min, max+1);
//     }
//     return numbers;
// }
// // Создаем функцию, которая наполнит массив рандомными числами.

// void PrintArray(int[] numbers){
//     for(int i = 0; i < numbers.Length; i++){
//         Console.Write($"{numbers[i]} ");
//     }
//     Console.WriteLine();
// }
// // Создаем функцию, которая выведет пользователю массив.
// void EvenIndex(int[] numbers){
// int sum = 0;
// for(int i = 0; i < numbers.Length; i++){
//     if(i % 2 != 0) sum = sum + numbers[i];
// }
// Console.WriteLine($"The sum of the array elements with an odd index is {sum}.");
// }
// // Создаем функцию, которая будет проверять на четность индекс элемента массива, а потом складывать эти элементы.
// NewRandomArray(numbers, 1, 2);
// PrintArray(numbers);
// EvenIndex(numbers);
// Даем вводные данные и запускаем все функции.

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Решение рабочее, но оно оч затратное. Оч плохой код.

// int[] numbers = new int[10];
// // Создаем массив с количеством элементов 10.
// int[] NewRandomArray(int [] numbers, int min, int max){

//     for(int i = 0; i < numbers.Length; i++){
//         numbers[i] = new Random().Next(min, max+1);
//     }
//     return numbers;
// }
// // Создаем функцию, которая наполнит массив рандомными числами.

// void PrintArray(int[] numbers){
//     for(int i = 0; i < numbers.Length; i++){
//         Console.Write($"{numbers[i]} ");
//     }
//     Console.WriteLine();
// }
// int BigNum(int[] numbers){
// int max = int.MinValue;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     } 
// }
// return max;
// }
// int SmallNum(int[] numbers){
// int min = int.MaxValue;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < min)
//     {
//         min = numbers[i];
//     } 
// }
// return min;
// }
// // Создаем функции, которые найдут максимальный и минимальный элемент массива.
// NewRandomArray(numbers, 1, 100);
// PrintArray(numbers);
// BigNum(numbers);
// SmallNum(numbers);
// Console.WriteLine();
// int a = BigNum(numbers);
// Console.WriteLine($"Max number is {a}");
// int b = SmallNum(numbers);
// Console.WriteLine($"Min number is {b}");
// Console.WriteLine();
// Console.WriteLine($"Answer is {a-b}.");
// // Запускаем все функции и находим рахницу между максимальным и минимальным элементом массива.
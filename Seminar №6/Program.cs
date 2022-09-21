// // Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[m];
// // Запрашиваем количество чисел и создаем массив.
// void InputNumbers(int m){
// for (int i = 0; i < m; i++){
//     Console.Write($"Input {i+1} number: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }
// // Создаем функцию с циклом для запроса всех чисел.
// int Count(int[] numbers)
// {
//   int count = 0;
//   for (int i = 0; i < numbers.Length; i++)
//   {
//     if(numbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }
// // Создаем функцию, которая будет проверять числа, на предмет того, больше ли они 0.

// InputNumbers(m);

// Console.WriteLine($"Numbers greater than zero: {Count(numbers)} ");
// // Запускаем функции и выводим ответ пользователю.

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];
// Создаем двумерный массив.
void InputCoeff(){
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Input coeff {i+1} for the equation (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Input coeff  k: ");
      else Console.Write($"Input coeff  b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
// Создаем функцию по запросу входных данных у пользователя.
double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}
// Создаем функцию, которая выполняет вычесления с коэфициентами.
void Intersection(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write("Lines coincide");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write("Straight lines are parallel");
  }
  else 
  {
    Decision(coeff);
    Console.Write("Зoint of intersection: ({crossPoint[0]}, {crossPoint[1]})");
  }
}
// Создаем функцию по опрделению и выводу данных пользователю.
InputCoeff();
Intersection(coeff);
// Запускаем все функции.

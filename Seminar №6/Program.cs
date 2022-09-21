// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте
// а первый - на последнем и т.д.)

// int[] ReverseMass(int[] array){
//     int temp = 0;
//     for(int i = 0; i < array.Length / 2;i++){
//         temp = array[i];
//         array[i] = array[array.Length - 1 -i];
//         array[array.Length-1-i] = temp;
//     }
//     return array;
// }
// int[] array = {1, 3, 6, 7, 2, 0};
// int[] revMas = ReverseMass(array);
// for(int i = 0; i < revMas.Length; i++){
//     Console.Write(revMas[i]+" ");
// }

// 2 вариант решения

// int[] ReverseMass(int[] array){
//     int temp = 0;
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--){
//         temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }
// int[] array = {1, 3, 6, 7, 2, 0};
// int[] revMas = ReverseMass(array);
// for(int i = 0; i < revMas.Length; i++){
//     Console.Write(revMas[i]+" ");
// }


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


Console.WriteLine($"\nЗадача 43.  Найти точку пересечения двух прямых \n");

// Теорема о неравенстве треугольника - каждая сторона треугольника меньше суммы двух других сторон.

// void Triangle(int num1, int num2, int num3){
// if (num1<num2+num3 && num2<num1+num3 && num3<num1+num2) Console.WriteLine("Answer ia Yes, it is.");
// else Console.WriteLine("Answer is No, it is.");
// }

// Console.WriteLine("Input num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input num3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Triangle(num1, num2, num3);

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);


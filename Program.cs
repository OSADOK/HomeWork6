
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//  Console.WriteLine("Иди нахуй кожанный");
//     int answer = 0;
//     foreach (int value in StringToNumbers(Console.ReadLine())) {
//         if (value > 0) {
//             answer++;
//         }
//     }
//     Console.WriteLine(answer);

  
//   static int CountNumbers(string line) {
//     int size = 1;
//     foreach (char symbol in line) {
//         if (symbol == ',' || symbol == ' ')
//         {
//             size++;
//         }
//     }
//     return size;
//   }
  
//   static int[] StringToNumbers(string line) {
//     int[] numbers = new int[CountNumbers(line)];
//     int j = 0;
//     string token = "";
//     foreach (char symbol in line) {
//         if (symbol == ' ' || symbol == ',') {
//             if (token != "") {
//                 numbers[j++] = int.Parse(token); 
//             }
//             token = "";
//             continue;
//         }
//         token += symbol;
//     }
//     if (token != "") {
//         numbers[j++] = int.Parse(token); 
//     }
//     return numbers;
//   }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Задайте значение b1");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение b2");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение k1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение k2");
double k2 = int.Parse(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");
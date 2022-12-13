// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите числа через пробел, закончите ввод нажатием <Enter>");
// int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
//             Select(e => Int32.Parse(e)).ToArray();

// Console.WriteLine($"В данном массиве {PositiveNumber(arr)} положительных чисел");

// int PositiveNumber(int[] arr)
// {
//     int count = 0;
//     foreach (var item in arr)
//     {
//         if (item > 0) count++;
//     }
//     return count;
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите коэффициент k1");
// string enterk1 = Console.ReadLine();
// double k1 = Convert.ToDouble(enterk1);

// Console.WriteLine("Введите коэффициент b1");
// string enterb1 = Console.ReadLine();
// double b1 = Convert.ToDouble(enterb1);

// Console.WriteLine("Введите коэффициент k2");
// string enterk2 = Console.ReadLine();
// double k2 = Convert.ToDouble(enterk2);

// Console.WriteLine("Введите коэффициент b2");
// string enterb2 = Console.ReadLine();
// double b2 = Convert.ToDouble(enterb2);

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Координаты точки пересечения по оси X = {x}; по оси Y = {y}");
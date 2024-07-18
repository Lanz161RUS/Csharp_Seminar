// Задача 1:
// Задайте одномерный массив из целых чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].

// int[] numbers = new int[] { 11, 15, 10, 20, 30, 40, 99, 4, 90, 3 };
// int count = 0;
// int minRange = 10;
// int maxRange = 90;

// foreach (int number in numbers)
//     if (number >= minRange && number <= maxRange)
//         count++;

// Console.WriteLine(count);

// Задача 2:
// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество четных чисел в массиве.

// int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
// int count = 0;

// foreach (int num in array)
// {
//     if (num % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);

// Задача 3:
// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементом массива.

// double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
// double MaxValue = array[0];
// double MinValue = array[1];
// double sub = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > MaxValue)
//     {
//         array[i] = MaxValue;
//     }
//     else if (array[i] < MinValue)
//     {
//         array[i] = MinValue;
//     }
// }
// sub = MaxValue - MinValue;
// Console.WriteLine(sub);
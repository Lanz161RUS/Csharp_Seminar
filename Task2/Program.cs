// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// void Main()
// {
//     string input = "";
//     int num;
//     bool exit = true;
//     while (exit)
//     {
//         input = Input();
//         if (int.TryParse(input, out num))
//             exit = !(num % 2 == 0);
//         else
//         if (input == "q")
//             exit = false;
//     }
//     string Input()
//     {
//         Console.WriteLine("Введите число или символ 'q' для выхода");
//         return Console.ReadLine()!;
//     }
// }
// Main();

// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// Console.WriteLine("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];

// void main()
// {
//     for (int i = 0; i < a; i++)
//     {
//         randomArray[i] = new Random().Next(99, 999);
//         Console.Write(randomArray[i] + " ");
//     }
// }

// int count(int[] randomArray)
// {
//     int count = 0;
//     for (int i = 0; i < randomArray.Length; i++)
//         if (randomArray[i] % 2 == 0)
//             count++;
//     return count;
// }

// main();
// Console.WriteLine();
// Console.Write(count(randomArray));


// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)// void Main()

// void Main()
// {
// int arraySize = ReadInt("Введите размер массива: ");
// int[] array = GenerateArray(arraySize, 0, 10);
// PrintArray(array);
// Array.Reverse(array);
// Console.WriteLine(String.Join(' ', array));
// }


// void PrintArray(int[] arrayForPrint)
// {
// for(int i = 0; i < arrayForPrint.Length; i++)
// System.Console.Write(arrayForPrint[i] + " ");

// System.Console.WriteLine();
// }

// int[] GenerateArray(int size, int minValue, int maxValue)
// {
// int[] tempArray = new int[size];
// Random rand = new Random();

// for (int i = 0; i < tempArray.Length; i++)
// tempArray[i] = rand.Next(minValue, maxValue);

// return tempArray;
// }

// int ReadInt(string msg)
// {
// System.Console.Write(msg);
// return Convert.ToInt32(Console.ReadLine());
// }

// Main();





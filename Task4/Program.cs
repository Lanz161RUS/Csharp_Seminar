// Задача 3 Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


// void Main()
// {
// int number = ReadInt("Введите число: ");
// PrintNumber(number);
// }

// void PrintNumber(int N)
// {
// if(N < 1) return;
// System.Console.Write(N + " ");
// PrintNumber(N - 1);
// }

// int ReadInt(string msg)
// {
// System.Console.Write(msg);
// return Convert.ToInt32(Console.ReadLine());
// }

// Main();

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// void Main()
// {
//     Console.Write("Введите число n: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число m: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     AkkermanFunction(m, n);
//     void AkkermanFunction(int m, int n)
//     {
//         Console.Write(A(m, n));
//     }

//     int A(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0 && m > 0)
//         {
//             return A(m - 1, 1);
//         }
//         else
//         {
//             return (A(m - 1, A(m, n - 1)));
//         }
//     }
// }
// Main();

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.



void Main()
{
    Console.Write("Введите значение M: ");
    int M = int.Parse(Console.ReadLine()!);

    Console.Write("Введите значение N: ");
    int N = int.Parse(Console.ReadLine()!);

    Numbers(M, N);
}

void Numbers(int current, int N)
{
    if (current <= N)
    {
        Console.Write(current + " ");
        Numbers(current + 1, N);
    }
}

Main();
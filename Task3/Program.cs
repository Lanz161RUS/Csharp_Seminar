// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// void Main()
// {
//     char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
//     string result = CreateStringFrom2DArray(charArray);
//     Console.WriteLine(result);
// }

// string CreateStringFrom2DArray(char[,] array)
// {
//     string result = "";
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i, j];
//         }
//     }
//     return result;
// }
// Main();

// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


// void Main()
// {
//     string input = "ASQWFQsa!-";
//     string result = input.ToLower();
//     Console.WriteLine(result);
// }
// Main();


// Задайте произвольную строку. Выясните, является ли она палиндромом.

// void Main()
// {
//     string input = "1234321";
//     bool isPalindrome = IsPalindrome(input);
//     Console.WriteLine(isPalindrome ? "Да" : "Нет");
// }
// bool IsPalindrome(string str)
// {
//     string normalized = new
//     string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//     return normalized.SequenceEqual(normalized.Reverse());
// }
// Main();
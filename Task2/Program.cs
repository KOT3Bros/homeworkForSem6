﻿// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Пример
// “aBcD1ef!-” => “abcd1ef!-” 

Console.Write("Введите строчку: ");
string str = Console.ReadLine();
str = str.ToLower(); // Перевод строки в нижний регистр
Console.WriteLine(str);
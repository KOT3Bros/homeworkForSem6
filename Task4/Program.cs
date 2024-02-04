// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.
// Пример
// “Hello my world” => “world my Hello”

string GetReverseString(string str)
{
    string result = string.Empty;
    string word = string.Empty;
    string current = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            word = $" {result}" + word;
            result = string.Empty;
        }
        else if (i == str.Length - 1)
        {
            result += str[i];
            word = result + word;
        }
        else
        {
            result += str[i];
        }
    }
    return word;
}

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
Console.WriteLine(GetReverseString(inputString));
GetReverseString(inputString);
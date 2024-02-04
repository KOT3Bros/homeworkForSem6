// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// Пример
// a b c => “abcdef”
// d e f 

string GetStringFromCharArray(char[,] array)
{
    string result = string.Empty; // пустая строка
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }
    return result;
}

char[,] chars = { {'a', 'b', 'c'},
                  {'d', 'e', 'f' } };
string res = GetStringFromCharArray(chars);
Console.WriteLine(res);
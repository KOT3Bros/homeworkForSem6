// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

bool CheckIfStringIsPalindrome(string str)
{
    bool isPalindrome = true;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
        {
            isPalindrome = false;
        }
    }
    return isPalindrome;
}

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
if (CheckIfStringIsPalindrome(inputString))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
/*
    Задайте произвольную строку. Выясните, является ли она палиндромом.
    Палиндро́м (от др.-греч. πάλιν — «назад, снова» и др.-греч. δρóμος — «бег, движение»), пе́ревертень[1] — число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях. Например, число 101; слова «топот»
*/
string str = "hello";
string strPalindrom = "level";
string strPalindrom2 = "racecar";
bool GetBoolPalindrom(string str)
{
    Console.WriteLine(str + " " + (str.Length / 2 + 1));
    int count = 0;
    for (int i = 0, j = str.Length - 1; i <= str.Length / 2; i++, j--)
    {
        Console.WriteLine($"i = {i}, j = {j}");
        if (str[i] == str[j])
        {
            count++;
        }
        Console.WriteLine(count);
    }
    if (count == str.Length / 2 + 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void PrintPalindromIfStringIsPalindrom(string str)
{
    if (GetBoolPalindrom(str))
    {
        Console.WriteLine($"{str} is a palindrom");
    }
    else
    {
        Console.WriteLine($"{str} is not a palindrom");
    }
}
PrintPalindromIfStringIsPalindrom(str);
PrintPalindromIfStringIsPalindrom(strPalindrom);
PrintPalindromIfStringIsPalindrom(strPalindrom2);
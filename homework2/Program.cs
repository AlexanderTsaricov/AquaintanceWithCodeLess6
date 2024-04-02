/*
    Задайте строку, содержащую латинские буквы в обоих регистрах. 
    Сформируйте строку, в которой все заглавные буквы заменены на строчные.
*/

string str = "Hello World";
string downRegistr = str.ToLower(); //Решение с помощью метода
Console.WriteLine(downRegistr);
string str2 = "Hello World";
string GetLowerStringFromUpperString(string str) // Решение через функцию (без встроенного метода)
{
    string upperLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
    string lowerString = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (upperLetters.Contains(str[i]))
        {
            lowerString += str[i].ToString().ToLower();
        }
        else
        {
            lowerString += str[i];
        }
    }
    return lowerString;
}
string downRegistr2 = GetLowerStringFromUpperString(str2);
Console.WriteLine(downRegistr2);
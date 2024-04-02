/*
    (не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
    Сформировать строку, в которой слова расположены в обратном порядке. 
    В полученной строке слова должны быть также разделены пробелами.
*/

string str = "hello world my friend";
str += " ";
int countSpace = 0;
foreach (char e in str)
{
    if (e == ' ')
    {
        countSpace++;
    }
}
Console.WriteLine(countSpace);
string[] strArray = new string[countSpace];
string word = "";
int count = 0;
int i = strArray.Length - 1;
foreach (char e in str)
{
    if (e == ' ')
    {
        strArray[i] = word;
        word = "";
        i--;
        continue;
    }
    word += e;
}
string flipStr = "";
foreach (string e in strArray)
{
    flipStr = flipStr + e + " ";
}

Console.WriteLine(flipStr);



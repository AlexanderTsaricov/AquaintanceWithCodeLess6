/*
    Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
*/

char[,] charMatrix = new char[,] { { 'H', 'e', 'l', 'l', 'o' }, { 'w', 'o', 'r', 'l', 'd' } };

string GetStringFromMatrix(char[,] matrix)
{
    string str = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str += matrix[i, j];
        }
        str += " ";
    }
    return str;
}
string str = GetStringFromMatrix(charMatrix);
Console.WriteLine(str);
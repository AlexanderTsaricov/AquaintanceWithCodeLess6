/*
    Задать массив char, заполнить и все элементы сохранить в переменную string
*/

char[] array = new char[] { 'r', '^', 'Л', 'r', '0' };
string str = "";
for (int i = 0; i < array.Length; i++)
{
    str += array[i]; // конкотинация str+char=>str
}
Console.WriteLine(str);
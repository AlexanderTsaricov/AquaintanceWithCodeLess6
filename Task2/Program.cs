/*
    На основе символов строки сформировать массив
    символов char
*/

Console.WriteLine("Введите строку");
string str = Console.ReadLine();
char[] array = new char[str.Length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = str[i];
    Console.WriteLine(array[i]);
}

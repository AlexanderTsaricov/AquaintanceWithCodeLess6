/*
    Считать строку с консоли и выяснить сколько
    среди введенных букв гласных
*/

Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();
string vowels = "aeiouy";
int count = 0;

for (int i = 0; i < userInput.Length; i++)
{
    if (vowels.Contains(userInput[i]))
    {
        i++;
    }
}
Console.WriteLine(count);
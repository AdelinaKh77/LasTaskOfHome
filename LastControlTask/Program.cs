Console.WriteLine("Выберите количество строк в массиве: ");
int count = int.Parse(Console.ReadLine());
string[] str = new string[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите элемент {i + 1}: ");
    string A = Console.ReadLine();
    str[i] = A;
}

for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3)
    {
        string[] minStr = new string[str.Length];
        minStr[i] = str[i];
        Console.WriteLine(minStr[i]);
    }
}
Console.ReadLine();
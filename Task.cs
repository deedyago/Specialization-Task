// Ввод данных пользователем
Console.WriteLine("\nInput your stroke array by elements separeted by spaces (ex. hello world)");
string strarray = Console.ReadLine()!;
string[] array = strarray.Split(' ');

Console.WriteLine("\nInput number of characters of an element to find: ");
int number = int.Parse(Console.ReadLine()!);

// Считаем размер выходного массива - делаю это, чтобы красивый вывод получился
int FindSize(string[] yourarray)
{
    int count = 0;
    for (int i = 0; i < yourarray.Length; i++)
    {
        if (yourarray[i].Length <= number)
        {
            count = count + 1;
        }
        else
        {
            count = count;
        }
    }
    return count;
}
 // Создаем новый массив

// Находим нужные нам элементы
string[] FindElements(string[] yourarray)
{
    string[] newarray = new string[FindSize(array)];
    int j = 0;
    for (int i = 0; i < yourarray.Length; i++)
    {
        if (yourarray[i].Length <= number)
        {

            newarray[j] = yourarray[i];
            j++;
        }
    }
    return newarray;
}
string[] newarray = FindElements(array);

Console.WriteLine();

// Вывод получившегося массива
void OutputPrint(string[] array1, string[] array2)
{
    Console.Write($"[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"'{array1[i]}' ");
    }
    Console.Write($"]");
    Console.Write(" => ");
    Console.Write($"[");
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"'{array2[i]}' ");
    }
    Console.Write($"]");
}
OutputPrint(array, newarray);
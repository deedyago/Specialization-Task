// Ввод данных пользователем
Console.WriteLine("Input your stroke array by elements separeted by spaces (ex. hello world)");
string strarray = Console.ReadLine();
string[] array = strarray.Split(' ');

Console.WriteLine("Input number of characters of an element to find: ");
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
string[] newarray = new string[FindSize(array)]; // Создаем новый массив

// Находим нужные нам элементы
void FindElements(string[] yourarray)
{
    int j = 0;
    for (int i = 0; i < yourarray.Length; i++)
    {
        if (yourarray[i].Length <= number)
        {

            newarray[j] = yourarray[i];
            j++;
        }
    }
}
FindElements(array);

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
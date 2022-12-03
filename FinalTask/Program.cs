// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

string[] GetStringArray(int size)
{ // метод создает массив строк, элементы которого вводятся пользователем с клавиатуры
    string[] stringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        stringArray[i] = Console.ReadLine()!;
    }
    return stringArray;
}

string[] GetShortenedArray(string[] array)
{
    string[] result = new string[];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if array[i].Length <= 3 
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

Console.Clear();

Console.Write("Введите размер массива: ");
int sizeOfarray = int.Parse(Console.ReadLine()!);
string[] workingArray = GetStringArray(sizeOfarray);
Console.WriteLine(String.Empty);
Console.WriteLine("Полученный массив: ");
Console.WriteLine(String.Empty);
Console.WriteLine(String.Join(", ", workingArray));
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

string[] GetStringArray(int size)
{
    string[] stringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        stringArray[i] = Console.ReadLine()!;
    }
    return stringArray;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeOfarray = int.Parse(Console.ReadLine()!);
string[] workingArray = GetStringArray(sizeOfarray);
Console.WriteLine(String.Empty);
Console.WriteLine("Полученный массив: ");
Console.WriteLine(String.Empty);
Console.WriteLine(String.Join(", ", workingArray));
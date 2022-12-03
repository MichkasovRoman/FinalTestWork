// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

string[] GetStringArray(int size)
{
    string[] stringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент массива: ");
        Console.ReadLine(stringArray[i]);
    }
    return stringArray;
}

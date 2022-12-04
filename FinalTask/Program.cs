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

int GetNumberOfElements(string[] array)
{ //метод считает количество строк в массиве, состоящих из не более, чем трех символов
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] GetShortenedArray(string[] array)
{ // метод формирует массив из элементов массива array, состоящих из трех и менее символов
    int threeSymbols = GetNumberOfElements(array); // количество строк в массиве array, 
    string[] result = new string[threeSymbols];    //                  состоящих из трех и менее символов       
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
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
Console.WriteLine("Введенный вами массив: ");
Console.WriteLine(String.Join(", ", workingArray));
string[] resultingArray = GetShortenedArray(workingArray);
Console.WriteLine(String.Empty);

if (resultingArray.Length == 0) 
{
    Console.WriteLine("В веденном вами массиве не оказалось строк длиной не более, чем 3 символа.");
}
else
{
    Console.WriteLine("Массив, составленный из строк введенного вами массива, длина которых не более, чем три символа: ");
    Console.WriteLine(String.Join(", ", resultingArray));
}

/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/


int[] Array(int[] array, int i)
{
    if (i < array.Length)
    {
        array[i] = new Random().Next(1, 50);
        Array(array, i + 1);
    }
    return array;
}

string OrigArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return OrigArray(array, i + 1) + $"{array[i]} ";
}

string RevArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return $"{array[i]} " + RevArray(array, i + 1);
}

Console.Clear();
Console.Write("Введите желаемое количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int i = 0;
int[] array = new int[n];
Array(array, i);
Console.WriteLine("Начальный массив: ");
Console.WriteLine(OrigArray(array, i));
Console.WriteLine("Конечный массив: ");
Console.WriteLine(RevArray(array, i));





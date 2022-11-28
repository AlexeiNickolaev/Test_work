// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array1 = new string[6] { "we", "are", "the", "champions", "my", "friends" };
string[] array2 = new string[array1.Length];

int n = 3;
int index = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= n)
    {
        array2[index] = array1[i];
        index++;
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
Console.WriteLine("Начальный массив:");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Появились пустые строки в заполняемом массиве:");
PrintArray(array2);
Console.WriteLine();
Array.Resize(ref array2, index);
Console.WriteLine("Конечный вид массива после удаления пустых строк:");
PrintArray(array2);
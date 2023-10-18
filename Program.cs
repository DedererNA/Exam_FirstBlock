int GetSize()
{
    Console.WriteLine("Введите размер списка:");
    int size=int.Parse(Console.ReadLine());
    return size;
}

string[] GetArr(int size)
{
    string[] array = new string[size];
    for (int i=0; i<size;i++)
    {
        Console.WriteLine($"Введите {i+1}-ю строку:");
        array[i]=Console.ReadLine();
    }
    return array;
}

string[] ResArr(string[] array)
{
    string[] newarray = new string[array.Length];
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length<4)
        {
            newarray[count]=array[i];
            count++;
        }
    }
    string[] result=new string[count];
    for (int i=0; i<count; i++)
    {
        result[i]=newarray[i];
    }
    return result;
}

string[] array=GetArr(GetSize());
Console.Write("Исходный список: ");
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine();
Console.Write("Результат: ");
Console.Write($"[{string.Join(", ", ResArr(array))}]");
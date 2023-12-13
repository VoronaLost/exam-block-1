string[] inputnumber()
{
    bool isNumber = false;
    Console.WriteLine($"Введите количество элементов в массиве:");
    int finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = int.TryParse(input, out finalNumber);
        if (finalNumber <= 0) isNumber = false;
        if (isNumber==false)
        Console.WriteLine($"Неверный формат, введите натуральное значение");
        }
    string[] arr = new string[finalNumber];
    for (int i=0; i< finalNumber; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i+1}:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void printarray(string[] arr)
{
    Console.WriteLine($"Вы ввели следующий массив:");
    Console.WriteLine($"'{String.Join("' ", arr)}'");
}

string[] array = inputnumber();
printarray(array);


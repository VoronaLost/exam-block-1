using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

string[] changedArray(string[] array)
{
    int p = 0;
    int amount = 3;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= amount) p +=1;
    string[] newArray = new string[p];
    for (int j = 0, k = 0; j < array.Length; j++)
        if (array[j].Length <= amount)
        {
            newArray[k] = array[j]; 
            k +=1;
        } 
    return newArray;
}

void printarray(string[] arr, string text)
{
    Console.WriteLine($"{text}");
    Console.WriteLine($"\"{String.Join("\" \"", arr)}\"");
}


string[] array = inputnumber();
printarray(array, "Вы ввели массив:");
string[] newArray = changedArray(array);
printarray(newArray, "Новый массив:");


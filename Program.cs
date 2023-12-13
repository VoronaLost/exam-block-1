using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

int inputnumber(string text, int condition)
{
    bool isNumber = false;
    Console.WriteLine($"{text}");
    int finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = int.TryParse(input, out finalNumber);
        if (finalNumber <= 0 | finalNumber > condition) isNumber = false;
        if (isNumber==false)
        Console.WriteLine($"Неверный формат, введите допустимое значение");
        }
return finalNumber;
}

string[] inputArray(int numberLength)
{
    string[] arr = new string[numberLength];
    for (int i=0; i < numberLength; i++)
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
int upperLimit = 2;
string[] sample = {"One", "two", "three", "four", "five",
 "Once", "I", "caught", "a", "fish", "alive"};
int choice = inputnumber("Для ввода массива с клавиатуры нажмите 1, для использования готового массива нажмите 2", upperLimit);
if (choice == 1)
{
int ammount = inputnumber("Введите количество элементов в массиве:",  int.MaxValue);
string[] array = inputArray(ammount);
printarray(array, "Вы ввели массив:");
string[] newArray = changedArray(array);
printarray(newArray, "Новый массив:");
}
else
{
printarray(sample, "Вы ввели массив:");
string[] newArray = changedArray(sample);
printarray(newArray, "Новый массив:");
}

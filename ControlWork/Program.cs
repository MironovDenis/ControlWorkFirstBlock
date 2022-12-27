/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
*/

void ControlWork()
{
    Console.Write("Задайте количество элементов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] inputArray = new string[n];
    int lenght = 3;

    InputArray(inputArray);
    Console.Write("Выводим заданный массив: ");
    PrintArray(inputArray);
    Console.WriteLine();
    PrintArray(OutputArray(inputArray, lenght));
}
ControlWork();

// Вводим элементы массива
void InputArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($" Введите {i + 1} элемент: ");
        inputArray[i] = Console.ReadLine();
    }
    Console.WriteLine();
}

void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write($"[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"]");
}

// Рассчитываем длину выходного массива
int Count(string[] inputArray, int lenght)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= lenght) count++;
    }
    return count;
}

// Формируем выходной массив
string[] OutputArray(string[] inputArray, int lenght)
{
    string[] outputArray = new string[Count(inputArray, lenght)];
    for (int i = 0, j = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= lenght)
        {
            outputArray[j] = inputArray[i];
            j++;
        }
    }
    Console.Write("Выводим выходной массив: ");
    return outputArray;
}
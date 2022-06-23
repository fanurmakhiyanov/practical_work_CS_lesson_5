// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(100, 999);
    }
    return arrA;
}

void PrintArray(int[] arrA)
{
    foreach(int element in arrA)
    {
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}

int CountPositiveElements(int[] arrA)
{
    int count = 0;
    foreach(int element in arrA)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] myArray = InitArray(10, 100, 999);
PrintArray(myArray);
int sumpositive = CountPositiveElements(myArray);
System.Console.WriteLine($"Количество четных чисел в массиве: {sumpositive}");
//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] MyArra(int b, int min, int max)
{
    int[] array = new int[b];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int SumNPos(int[] arr)
{
    int SumN = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        SumN += arr[i];
    }
    return SumN;
}

int[] myArray = MyArra(7, -10, 10);
printArr(myArray);
int sum = SumNPos(myArray);
Console.WriteLine($"{sum}");
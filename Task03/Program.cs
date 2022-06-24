// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

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

int SearchMinMaxElements(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    int difference = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    difference = max - min;
        return difference;
}

int[] myArray = MyArra(5, 0, 99);
printArr(myArray);
int dif = SearchMinMaxElements(myArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {dif}");

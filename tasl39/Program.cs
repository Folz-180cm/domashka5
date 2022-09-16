// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
int[] arr = new int[5];

void ArrEight(int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr1[i]},");
        else
            Console.Write($"{arr1[i]}");
    }

    Console.WriteLine("]");
}
void ReverseArray(int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size -1;

    while (index1 < index2)
    {
        int obj = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = obj;
        index1++;
        index2--;
    }
}

void ReverseArrayFor (int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[size - 1 - i];
        arr[size - 1 - i] = temp;
    }
}

ArrEight(arr);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
ReverseArrayFor(arr);
PrintArray(arr);
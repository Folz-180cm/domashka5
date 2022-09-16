// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] arr = new int[4];


void ArrEight(int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = new Random().Next(0, 1000);
    }
}
void CountChet(int[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0){
            count++;
        }
            
    }
    Console.WriteLine($"количество чётных чисел в массиве = {count}");
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
ArrEight(arr);
PrintArray(arr);
CountChet(arr);

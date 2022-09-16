// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] arr = new int[4];


void ArrEight(int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = new Random().Next(0, 100);
    }
}
void CountNechet(int[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2==1){
            count += arr1[i];
        }
            
    }
    Console.WriteLine($"Сумма нечётных чисел в массиве = {count}");
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
CountNechet(arr);
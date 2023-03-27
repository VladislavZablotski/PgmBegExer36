// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillUpArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)   {arr[i] = new Random().Next(0, 100); }
}

int SumOddPositions(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum+=arr[i];
    }
    return sum;
}

int[] array = new int[10];

FillUpArray(array);
Console.WriteLine($"Массив: {String.Join(",", array)}");
Console.WriteLine($"Сумма значений, стоящих на нечетных позициях: {SumOddPositions(array)}");
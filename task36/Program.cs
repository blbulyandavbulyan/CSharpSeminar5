//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0


//возвращает сумму элементов стоящих на нечётных позициях
int getSumOfElementsInNotEvenPositionsInArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += arr[i];
        }
    }
    return result;
}
int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(min, max + 1);
    }
    return arr;
}
int randomLength = Random.Shared.Next(1, 20);
int[] arr = generateRandomArray(randomLength, -100, 100);
int countElementInEvenPositions = getSumOfElementsInNotEvenPositionsInArray(arr);
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine($"Сумма элементов на не чётных позицих {countElementInEvenPositions}");
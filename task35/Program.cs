//Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5

//возвращает количество элементов массива принадлижащих промежутку [min, max]
int getCountNumbersInArrayBetweenMinAndMax(int[] arr, int min, int max)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max)
        {
            result++;
        }
    }
    return result;
}
//generates ranodom array, which size is length and random value in range [min, max]
int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(min, max + 1);
    }
    return arr;
}
int[] randomArray = generateRandomArray(123, 0, 150);
const int minimalELemntToCount = 10;
const int maximumElementToCount = 99;
int count = getCountNumbersInArrayBetweenMinAndMax(randomArray, minimalELemntToCount, maximumElementToCount);
Console.WriteLine(string.Join(" ", randomArray));
Console.WriteLine($"Количество элементов в промежутке [{minimalELemntToCount}, {maximumElementToCount}]: {count}");
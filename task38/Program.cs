/// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
//функция возвращает минимальный элемент в массиве если minimal == true, иначе она возвращает максимальный
int getMinimalOrMaximumElementInArray(int[] arr, bool minimal)
{
    int result = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if((minimal && (arr[i] < result)) || (!minimal && arr[i] > result))
        {
            result = arr[i];
        }
    }
    return result;
}
int getDifferenceBetweenMinAndMaxElementInArray(int[] arr)
{
    int min = getMinimalOrMaximumElementInArray(arr, true);
    int max = getMinimalOrMaximumElementInArray(arr, false);
    return max - min;
}
//generates ranodom array, which size is length and random value in range [min;max]
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
int[] arr = generateRandomArray(randomLength, 100, 999);
int differenceBetweenMinAndMaxInArray = getDifferenceBetweenMinAndMaxElementInArray(arr);
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве: {differenceBetweenMinAndMaxInArray}");
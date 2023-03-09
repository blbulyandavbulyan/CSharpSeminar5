//task31
int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(min, max);
    }
    return arr;
}
int getSummOfPositiveOrNegativeNumbers(int[] arr, bool positive)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (positive) {
            if (arr[i] > 0) result += arr[i];
        }
        else if (arr[i] < 0)result += arr[i];
    }
    return result;
}

int[] arr = generateRandomArray(12, -9, 10);
int positiveSummOfArray = getSummOfPositiveOrNegativeNumbers(arr, true);
int negativeSummOfArray = getSummOfPositiveOrNegativeNumbers(arr, false);
Console.WriteLine($"Массив: \n{String.Join(" ", arr)}\n");
Console.WriteLine($"Отрицательная сумма {negativeSummOfArray}");
Console.WriteLine($"Положительная сумма {positiveSummOfArray}");
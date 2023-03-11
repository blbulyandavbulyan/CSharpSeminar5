//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int getCountOfEvenNumbersInArray(int[] arr)
{
    int result = 0;
    foreach(int a in arr){
        if(a % 2 == 0) result++;
    }
    return result;
}
//generates ranodom array, which size is length and random value in range [min;max]
int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(min, max + 1);
    }
    return arr;
}
int randomLength = Random.Shared.Next(1, 20);
int[] arr = generateRandomArray(randomLength, 100, 999);
int countOfEvenNumbers = getCountOfEvenNumbersInArray(arr);
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine($"Количество чётных чисел: {countOfEvenNumbers}");
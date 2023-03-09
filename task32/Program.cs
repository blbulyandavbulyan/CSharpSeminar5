/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
using System.Buffers;

int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(min, max);
    }
    return arr;
}
void invertSignInArr(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] *= (-1);
    }
}
int[] arr = generateRandomArray(20, -200000, 200000);
Console.WriteLine($"Array: {string.Join(" ", arr)}");
invertSignInArr(arr);
Console.WriteLine($"New array: {string.Join(" ", arr)}");
/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/
bool findNumberInArray(int[] arr, int value)
{
    for(int i =  0; i < arr.Length; i++)
    {
        if (arr[i] == value) return true;
    }
    return false;
}
int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(min, max);
    }
    return arr;
}
int[] arr = generateRandomArray(20, -200000, 200000);
Console.WriteLine($"Array: {string.Join(" ", arr)}");
Console.Write("Enter your number to find: ");
int finding_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(findNumberInArray(arr, finding_number) ? "да" : "нет");
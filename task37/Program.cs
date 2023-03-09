/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
int[] convertArray(int[] arr)
{
    int[] result = new int[arr.Length / 2 + arr.Length % 2];
    for(int i = 0; i < arr.Length / 2; i++)
    {
        int j = arr.Length - i - 1;
        result[i] = arr[i] * arr[j];
    }
    if(arr.Length % 2 != 0)
    {
        result[result.Length - 1] = arr[arr.Length / 2];
    }
    return result;
}
int[] arr = { 6, 7, 3, 6 };
int[] converted = convertArray(arr);
Console.WriteLine(string.Join(" ", converted));
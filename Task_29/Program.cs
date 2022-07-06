int[] array = new int[8];
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"Введите {i + 1} число массива: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++) Console.Write(array[j]);
}
FillArray(array);
PrintArray(array);

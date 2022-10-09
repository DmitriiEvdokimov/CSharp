int[] arr = { 1, 5, 8, 4, 1, 5, 9, 6, 5, 1 };
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void UpArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        int minPosition = i;
        int min = array1[i];
        for (int j = i+1 ; j < array1.Length; j++)
        {
            if (array1[j] < min)    
            {
                minPosition = j;
                min = array1[j];
            }
        }
        int temp = array1[i];
        array1[i] = array1[minPosition];
        array1[minPosition] = temp;
    }
}

PrintArray(arr);
Console.WriteLine();
UpArray(arr);
PrintArray(arr);

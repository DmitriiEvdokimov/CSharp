void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index1 = 0;
    int position = -1;

    while (index1 < count)
    {
        if (collection[index1] == find)
        {
            position = index1;
            break;
        }
        index1++;
    }
    return position;
} 

int[] array = new int[10];

FillArray(array); 
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos);
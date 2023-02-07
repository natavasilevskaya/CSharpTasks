// Программа принимает на вход массив из 3 чисел и выводит в терминал значение наибольшего

int[] CreateRandomArray(int size, int min, int max)
{
    int[] myArray = new int[size];
    {
        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = new Random().Next(min,max);
        }
        return myArray;
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int MinMaxNum (int[] array)
{
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

int[] myArray = CreateRandomArray(12,1,99);
PrintArray(myArray);

Console.WriteLine(MinMaxNum(myArray));

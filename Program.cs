double GetDiffMinMaxElements(double[] array)
{
    double minNum = array[0];
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (minNum > array[i])
        {
            minNum = array[i];
        }
        if (maxNum < array[i])
        {
            maxNum = array[i];
        }
    }
    double diffMinMax = Math.Round(maxNum - minNum, 2);
    return diffMinMax;
}

double[] GetRandomArray(int Length, int min, int max)
{
    double[] array = new double[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (max + min) - min, 2);
    }
    return array;
}

double[] array = GetRandomArray(5, 0, 100);
Console.Write($"[{String.Join(", ",array)}] => ");
Console.Write(GetDiffMinMaxElements(array));
Console.Write("Введите количество строк: ");
int linesCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnesCount = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[,] array = new int[linesCount, columnesCount];
for (int i = 0; i < array.GetLength(0); i++)
{
        for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write("{0} ", array[i, j]);
    }
Console.WriteLine();
}

Console.WriteLine("По строкам: ");
int[] lines = new int[columnesCount];
for (int i = 0; i < linesCount; i++)
{
    for (int j = 0; j < columnesCount; j++)
    lines[j] = array[i, j];
    BubbleSort(lines);
    Insert(true, i, lines, array);
}

PrintArray(array);
Console.WriteLine("По столбцам: ");
int[] columnes = new int[linesCount];
for (int i = 0; i < columnesCount; i++)
{
    for (int j = 0; j < linesCount; j++)
    columnes[j] = array[j, i];
    BubbleSort(columnes);
    Insert(false, i, columnes, array);
}
PrintArray(array);


void Insert(bool row, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
        {
            if (row)
                dest[dim, k] = source[k];
            else
                dest[k, dim] = source[k];
        }
}
        
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                Console.Write(array[a, b] + " ");
            }
            Console.WriteLine();
        }
}

void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    for (int j = 0; j < inArray.Length - i - 1; j++)
    {
        if (inArray[j] > inArray[j + 1])
        {
            int value = inArray[j];
            inArray[j] = inArray[j + 1];
            inArray[j + 1] = value;
        }
    }
}

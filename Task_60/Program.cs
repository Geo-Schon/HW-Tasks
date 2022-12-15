int[,,] array3 = new int[2, 2, 2];
FillArray(array3);
PrintIndex(array3);

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3.GetLength(2); k++)
            {
                Console.Write($" {array3[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

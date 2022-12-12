Random random = new Random();
int[,] arr = new int[random.Next(4, 8), random.Next(4, 8)];
Console.WriteLine ("Массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");
Console.WriteLine ("Среднее арифметическое элементов в каждом столбце: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    double spar = sum / arr.GetLength(0);
    Console.Write($"{ Math.Round (sum / arr.GetLength(0),1)} ; ");
}
Console.ReadLine();

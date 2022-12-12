Console.Write("Введите количество строк в массиве: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите строку: ");
int positionA = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int positionB = Convert.ToInt32(Console.ReadLine()) - 1;

Random random = new Random();
int[,] arr = new int[lines, columns];
Console.WriteLine("Массив ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(1, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (positionA < 0 | positionA > arr.GetLength(0) - 1 | positionB < 0 | positionB > arr.GetLength(1) - 1)
{
Console.WriteLine("Такого числа в масииве нет  ");
}
    else
{
    Console.WriteLine("Значение элемента массива: {0}", arr[positionA, positionB]);
}
Console.ReadLine();

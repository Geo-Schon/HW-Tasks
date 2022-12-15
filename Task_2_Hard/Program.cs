Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[,] array = new int[m, n];
int index;
for (int i = 0; i < array.GetLength(0); i++)
{
        for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write("{0} ", array[i, j]);
    }
    {
        for(index = 0; index<array.Length; index++);
    }
Console.WriteLine();
}

// int min = 1;
// int index = 0;
// for (int i = 1; i < array.Length; i++)
// if (min > array[m, n])
//     {
//         min = array[m, n];
//         index = i;
//     }
// Console.WriteLine("Индекс минимального элемента массива  " + index);
// Console.ReadKey();



// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// найти максимальное число и его индекс. Вывести эту информацию на экран.
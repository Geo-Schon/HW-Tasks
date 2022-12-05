Console.WriteLine("Введите размер массива  ");
int MassiveSize = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[MassiveSize];
RandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int v = 0; v < numbers.Length; v++)
{
    if (numbers[v] > max)
        {
            max = numbers[v];
        }
    if (numbers[v] < min)
        {
            min = numbers[v];
        }
}

Console.WriteLine($"В массиве {numbers.Length} чисел");
Console.WriteLine ($"Максимальное значение: {max}; Минимальное значение: = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");

void RandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}

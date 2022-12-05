Console.WriteLine("Введите размер массива:  ");
int MassiveSize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[MassiveSize];
RandomNumbers(numbers);
PrintArray(numbers);
int count = 0;
for (int v = 0; v < numbers.Length; v++)
if (numbers[v] % 2 == 0)
count++;
Console.WriteLine($"В массиве {numbers.Length} чисел, {count} - чётные");

void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

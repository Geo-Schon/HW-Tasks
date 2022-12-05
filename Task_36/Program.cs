Console.WriteLine("Введите размер массива  ");
int MassiveSize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[MassiveSize];
RandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int v = 0; v < numbers.Length; v+=2)
    sum = sum + numbers[v];
    Console.WriteLine($"В массиве {numbers.Length} чисел, сумма цифр cтоящих на нечётных позициях - {sum}");

void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,1000);
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

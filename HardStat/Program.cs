Random Num = new Random();
int mas_size = 10;
int[] array = new int [10] ;
double arith_mean = 0;
for (int i = 0; i < mas_size; i++) 
{ 
    array[i] = Num.Next(1, 10);
    arith_mean += array[i];
}
arith_mean = arith_mean / mas_size;
Console.WriteLine("Массив:");
Print(array);
Console.WriteLine($"Максимальный элемент массива {array.Max()}");
Console.WriteLine($"Минимальный элемент массива {array.Min()}");
Console.WriteLine($"Среднее арифметическое элементов массива {arith_mean}");
Console.ReadKey();

void Print(int[] array)
{
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();

}

//  static void Main(string[] args)
//         {
//             int[] intArray = { 1, 3, 5, -4, 6, 9, 56, 34, 12, 0, -9, 4, -2, 8, -5, -12, 0, 9 };
//             int min = intArray.Min();
//             int min_index = Array.FindIndex(intArray, delegate(int i)
//             {
//                 return i == min;
//             });
//             Console.WriteLine("Minimum value in array is: {0}, index of minimum value is: {1}",
//                               min,min_index);
 
//             for (int i = 0; i < intArray.Length; i++)
//             {
//                 if (intArray[i] % 2 != 0)
//                 {
//                     Console.WriteLine("Index: {0}, Value: {1}", i, intArray[i]);
//                 }
//             }
//             Console.ReadLine();
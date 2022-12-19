Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int numN = Convert.ToInt32(Console.ReadLine());

void NumberSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    NumberSum(numM, numN, sum);
}
NumberSum(numM, numN, 0);

// int NumberSum(int numM, int numN)
// {
//     if (numM == 0) return (numN * (numN + 1)) / 2;            
//     else if (numN == 0) return (numM * (numM + 1)) / 2;       
//     else if (numM == numN) return numM;            
//     else if (numM < numN) return numN + NumberSum(numM, numN - 1);
//     else return numN + NumberSum(numM, numN + 1);
// }

// Console.Write("Введите число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {NumberSum(numM, numN)}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }
    int[] numbers = new int [count];
    
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string val = "";
        while (input [i] != ' ')
        {
            if(i != input.Length - 1)
            {
                val += input [i].ToString();
                i++;
            }
            else
            {
                val += input [i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(val);
        index++;
    }
    return numbers;
}

Console.Write("Введите числа: ");
int[]numbers = StringToNum(Console.ReadLine());
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество чисел больше 0: {sum}");

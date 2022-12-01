int num = ReadInt("Введите число: ");
int len = NumLen(num);
SumNum(num, len);

int NumLen(int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}

void SumNum(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine($"Cумма цифр числа = {sum}");
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}






// принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
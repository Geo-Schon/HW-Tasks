Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >=100)
{
    while (num >= 100)
        {
        num /= 10;
        }
    int res = num % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Нет");
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

void NumberCounter (int num)
{
    if (num < 0) Console.Write($"{num} не натуральное число");
    if (num == 0) return;
    Console.Write("{0} ", num);
    NumberCounter (num - 1);
}
NumberCounter(num);

// void NumberCounter(int num)
// {
//     if (num <= 0)
//     {
//         return;
//     }
//     else
//     {
//         Console.Write(num + " ");
//         NumberCounter(num - 1);
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// NumberCounter(num);


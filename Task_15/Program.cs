Console.WriteLine("Введите цифру, обозначающую день недели: ");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day >= 7)
{
    Console.WriteLine("Число вне пределов 7 дней");
}
else
{
    if (Day >= 6)
        Console.WriteLine("Это выходной день!");
    if (Day < 5)
        Console.WriteLine("Это будний день!");
}
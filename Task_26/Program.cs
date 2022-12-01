Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = 0;
while (num>0)
    {
        counter++;
        num = num / 10;
    }
Console.WriteLine("Данное число содержит " + counter + " цифры");


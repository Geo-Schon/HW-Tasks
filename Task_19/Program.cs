int num, rem, sum = 0, temp;
Console.WriteLine("Введите пятизначное число");
num = Convert.ToInt32(Console.ReadLine());
    temp = num;
    while (num > 0)
    {
        rem = num % 10;
        num = num / 10;
        sum = sum * 10 + rem;
    }
    if (temp == sum)
    {
    Console.WriteLine("Это число палиндром");
    }
    else
    {
    Console.WriteLine("Это число не палиндром");
    }
    Console.ReadLine();
    

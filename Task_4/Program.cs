Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numС = Convert.ToInt32(Console.ReadLine());
    
    if (numA > numB)
    {
        if (numA > numС)
        {
            Console.WriteLine("Первое число максимальное");
        }
        else
        {
            Console.WriteLine("Третье число максимальное");
        }
    }
    else 
    {
        if (numB > numС)
        {
            Console.WriteLine("Второе число максимальное");
        }
        else
        {
            Console.WriteLine("Третье число максимальное");
        }
    }
int num = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень: ");

Console.WriteLine($"{num} * {degree} = " + Math.Pow(num, degree));

// Если вам нужно получить целое число степени, то можете сделать так:

// int i = Convert.ToInt32(Math.Pow(5, 3));


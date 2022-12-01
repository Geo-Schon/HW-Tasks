int num = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень: ");
ToDegree(num, degree);

void ToDegree(int num, int degree)
{
    Console.WriteLine($"{num} в {degree} степени = " + Math.Pow(num, degree));
}

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}


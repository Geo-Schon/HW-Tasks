Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 1;

while (res < num)
    {
    Console.WriteLine(res+1);
    res+= 2;
    }
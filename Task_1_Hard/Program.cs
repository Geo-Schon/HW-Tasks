int FibRecursive (int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }
    if (n >= 0)
    {
        return FibRecursive (n-1) + FibRecursive (n-2);
    }
    else
    {
        return (int)Math.Pow (-1, (n+1)) *  FibRecursive(Math.Abs(n));
    }
}

int Fib (int n)
{
    int cur = 0;
    int prev = 1;
    int sign = 1;

    if (n < 0)
    {
        sign = (int)Math.Pow(-1, (n+1));
    }

    n = Math.Abs(n);

    for (int d = 0; d <= n; d++)
    {
        cur = cur + prev;
        prev = cur - prev;
    } 
    return cur * sign;
}

int n = 0;
{
    for (int j = -8; j <= 8; n++)
    {
        int result1 = FibRecursive(n);
        Console.Write (result1 + " ");
    }
    Console.WriteLine();
    for (int k = -8; k <= 8; k++)
    {
        int result2 = Fib(n);
        Console.Write (result2 + " ");
    }
    Console.WriteLine();
    for (int i = 0; i <= 5; i++)
    {
        Console.WriteLine ();
    }
}  

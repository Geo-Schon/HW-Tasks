﻿Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
    if(numA > numB)
    {
    Console.WriteLine("Первое число больше второго");
    }
     else if (numA < numB)
     {
     Console.WriteLine("Первое число меньше второго");
    }
    else
     {
    Console.WriteLine("Числа равны");
    }   
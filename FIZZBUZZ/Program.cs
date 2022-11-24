for (int inx =1; inx <= 100; inx++)
{
    string str = "";
    if (i % 3 == 0)
    {
        str += "Fizz";
    }
    if (i % 5 == 0)
    {
        str += "Buzz";
    }
    if (str.length == 0)
    {
        str = i.ToString();
    }
    Console.WriteLine(str);
}
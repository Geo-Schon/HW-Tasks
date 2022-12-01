int LenArray = 8;
int[] NewArray = new int[LenArray];
for (int index = 0; index < NewArray.Length; index++)
{
    NewArray[index] = new Random().Next(1,100);
    Console.Write(NewArray[index] + " ");
}
Console.Write (Convert.ToInt32(Console.ReadLine()));

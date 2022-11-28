Console.WriteLine("Введите число: ");
int num_cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] num_cube)
{
  int counter = 0;
  int length = num_cube.Length;
  while (counter <  length)
  {
    num_cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] amount)
{
  int count = amount.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(amount[index]+ " ");
    index++;
  }
} 
int[] arry = new int[num_cube+1];
Cube(arry);
PrintArry(arry);
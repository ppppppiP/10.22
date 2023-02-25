static int Max1(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine("Введите 6 чисел: ");
int[] arr = new int[6];

for(int a = 0; a< arr.Length;a++)
{
    arr[a] = Convert.ToInt32(Console.ReadLine());
}


if (Max1(arr[0], arr[1])>Max1(arr[2], arr[3])&& Max1(arr[0], arr[1])> Max1(arr[4], arr[5]))
{
    Console.WriteLine("Максимальное число: " + Max1(arr[0], arr[1]));

}else if(Max1(arr[2], arr[3])> Max1(arr[0], arr[1])&& Max1(arr[2], arr[3])> Max1(arr[4], arr[5]))
{
    Console.WriteLine("Максимальное число: " + Max1(arr[2], arr[3]));

}else if(Max1(arr[4], arr[5])> Max1(arr[0], arr[1])&& Max1(arr[4], arr[5])> Max1(arr[2], arr[3]))
{
    Console.WriteLine("Максимальное число: "+Max1(arr[4], arr[5]));
}
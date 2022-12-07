void Mass(int n)
{
    int[] array = new int[n];
    for (int i = 0;i<n;i++)
    {
        array[i] = new Random().Next(-50,50);
        Console.Write($"{array[i]} ");
    }
    int sum1 = 0;
    for (int i = 0;i<n;i++)
    {
        if ((i % 2) == 0)
        {
            sum1 = sum1 + array[i];
        } 
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма на позициях = {sum1}");
}
Console.WriteLine("Введите кол во");
int s = int.Parse(Console.ReadLine());
Mass(s);
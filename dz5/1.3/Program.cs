void Mass(int n)
{   
    Console.WriteLine("Введите числа");
    double[] array = new double[n];
    for (int i = 0;i<n;i++)
    {
        array[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0;i<n;i++)
    {
        Console.Write($"{array[i]} ");
    }
    double max = array[0];
    double min = array[0];
    for (int i = 0;i<n;i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        } 
        else if (array[i] < min)
        {
            min = array[i];
        } 
    }
    Console.WriteLine();
    double result = Math.Round((max-min),3);
    Console.WriteLine($"Max - min = {result}");
}
Console.WriteLine("Введите кол во");
int s = int.Parse(Console.ReadLine());
Mass(s);
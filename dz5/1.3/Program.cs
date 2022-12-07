void Print(double [] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] Mass(int size)
{
    Random rand = new Random(DateTime.Now.Millisecond);
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = rand.NextDouble() * 100;
    return arr;
}

void Reshalka(double[] array,int n)
{
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
double[] newarr = Mass(s);
Print(newarr);
Reshalka(newarr,s);
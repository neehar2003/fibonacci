Console.Write("Enter how many Fibonacci numbers to generate: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(", ", Fibonacci(n)));

static List<int> Fibonacci(int n)
{
    var series = new List<int>();
    int n1 = 0;
    int n2 = 1;

    for (int i = 0; i < n; i++)
    {
        series.Add(n1);
        int sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return series;
}

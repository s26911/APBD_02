class Program
{
    public static void Main(string[] args)
    {
        int[] tab = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        Console.WriteLine();
        Console.WriteLine("Średnia: " + Srednia(tab));
    }

    static double Srednia(int[] tab)
    {
        double sum = 0;
        foreach (var i in tab)
            sum += i;

        return sum / tab.Length;
    }
}
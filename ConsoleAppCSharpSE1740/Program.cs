namespace ConsoleAppCSharpSE1740.Programming;

public class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 20;
        Console.WriteLine($"Sum = {Add(a,b)}");
        Console.ReadKey();
    }
    public static int Add(int x,int y) => x + y;
    public static double Add(double x,double y) => x + y;
    public static double Add(int x, int y, double z) => Add(Add(x, y), z);
}
namespace ConsoleAppCSharpSE1740.Programming;

public class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 20;
        Console.WriteLine($"Sum = {Add(a,b)}");
        Console.WriteLine($"Sum = Tong cac so tu 1 den 100 la: {Sum(100)}");
        Console.WriteLine($"Sum = Tong cac so tu 1 den 100 la: {Total(100)}");
        Console.ReadKey();
    }
    public static int Add(int x,int y) => x + y;
    public static double Add(double x,double y) => x + y;
    public static double Add(int x, int y, double z) => Add(Add(x, y), z);
    /*
     Required:
    - Sum of serials (even) : 1+2+3+...+n?:
                +loop
                +recursion
     */ 
    //loop
    public static long Sum(int n)
    {
        long total = 0;
        int i = 1;
        while (i <= n)
        {
            if(i % 2 == 0) total += i; //total = total + i; -=, *=, /=, %=...
            i++; //i=i+1; unary
        }


        return total;
    }
    public static long Total(int n)
    {
        if (n == 0 || n == 1) return n;
        return n + Total(n - 1);
    }
}
using System;

class Program
{
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static void Main()
    {
        int n = 51;  // Lahko spremenite to vrednost, vendar bo počasno za velike n
        Console.WriteLine("Fibonacci(" + n + ") = " + FibonacciRecursive(n));
    }
}

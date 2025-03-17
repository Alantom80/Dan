using System;
using System.Collections.Generic;

class Program
{
    private static Dictionary<int, int> memo = new Dictionary<int, int>();

    public static int FibonacciMemoized(int n)
    {
        if (n <= 1)
            return n;
        
        if (memo.ContainsKey(n))
            return memo[n];

        memo[n] = FibonacciMemoized(n - 1) + FibonacciMemoized(n - 2);
        return memo[n];
    }

    static void Main()
    {
        int n = 4268;  // Zdaj bo hitreje
        Console.WriteLine("Fibonacci(" + n + ") = " + FibonacciMemoized(n));
    }
}
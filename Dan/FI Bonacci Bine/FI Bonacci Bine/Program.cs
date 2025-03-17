using System;

class Program
{
    public static double FibonacciBinet(int n)
    {
        double phi = (1 + Math.Sqrt(5)) / 2;
        double psi = (1 - Math.Sqrt(5)) / 2;
        return (Math.Pow(phi, n) - Math.Pow(psi, n)) / Math.Sqrt(5);
    }

    static void Main()
    {
        int n = 1000;  // Uporaba Binetove formule
        Console.WriteLine("Fibonacci(" + n + ") = " + Math.Round(FibonacciBinet(n)));
    }
}


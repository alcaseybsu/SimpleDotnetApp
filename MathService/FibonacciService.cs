namespace MathService;

public class FibonacciService
{
    public static int GetFibonacciValueOf(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Input cannot be negative");
        }

        if (n <= 1)
        {
            return n;
        }

        int a = 0;
        int b = 1;

        for (int i = 2; i <= n; i++)
        {
            (a, b) = (b, a + b);
        }

        return b;
    }
}

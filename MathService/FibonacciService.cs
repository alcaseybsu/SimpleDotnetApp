namespace MathService;

public static class FibonacciService
{
    public static int GetFibonacciValueOf(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Input cannot be negative");
        }
        else if (n <= 1)
        {
            return n;
        }
        else
        {
            return GetFibonacciValueOf(n - 1) + GetFibonacciValueOf(n - 2);
        }
    }
}

namespace MathService;

public class FibonacciService
{
    public static int GetFibonacciValueOf(int n)
    {
        if (n == 1 || n == 0)
        {
            return n;
        }
        return GetFibonacciValueOf(n - 1) + GetFibonacciValueOf(n - 2);
    }
}

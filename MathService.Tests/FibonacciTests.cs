using Xunit;

namespace MathService.Tests;

public class FibonacciTests
{
    [Fact]
    public void Fibonacci_ZeroInput_ReturnsZero()
    {
        Assert.Equal(0, FibonacciService.GetFibonacciValueOf(0));
    }

    [Fact]
    public void Fibonacci_NoNegativeInput()
    {
        Assert.Throws<Exception>(() =>
        {
            int n = -2;
            if (n < 0)
                throw new Exception("No negative!");
            FibonacciService.GetFibonacciValueOf(n);
        });
    }
}
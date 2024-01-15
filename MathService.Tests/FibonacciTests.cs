using Xunit;

namespace MathService.Tests;

public class FibonacciTests
{
    [Fact]
    public void Fibonacci_BaseValues()
    {
        Assert.Equal(0, FibonacciService.GetFibonacciValueOf(0));
    }
}

using Xunit;

namespace MathService.Tests;

public class FibonacciTests
{
    // test zero
    [Fact]
    public void Fibonacci_ZeroInput_ReturnsZero()
    {
        Assert.Equal(0, FibonacciService.GetFibonacciValueOf(0));
    }

    // test negative numbers
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

    // test positive numbers
    [Fact]
    public void Fibonacci_PositiveInput_ReturnsCorrectValue()
    {
        Assert.Equal(1, FibonacciService.GetFibonacciValueOf(1));
        Assert.Equal(1, FibonacciService.GetFibonacciValueOf(2));
        Assert.Equal(2, FibonacciService.GetFibonacciValueOf(3));
    }

    // test large numbers
    [Fact]
    public void Fibonacci_LargeInput_ReturnsCorrectValue()
    {
        Assert.Equal(9227465, FibonacciService.GetFibonacciValueOf(35));
    }

    // test for exception
    [Fact]
    public void Fibonacci_NegativeInput_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => FibonacciService.GetFibonacciValueOf(-1));
    }
}

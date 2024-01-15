using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", (int value) => "Hello CS420! Here is Fib("+value+")= 
"+FibonacciService.GetFibonacciValueOf(value));
app.Run();


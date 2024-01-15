using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => $@"Hello CS420! Here is Fib(6)= 
"+FibonacciService.GetFibonacciValueOf(6));
app.Run();



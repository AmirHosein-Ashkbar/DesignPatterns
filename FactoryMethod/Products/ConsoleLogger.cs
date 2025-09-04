namespace FactoryMethod.Products;
public class ConsoleLogger : ILogger
{
    public void Log(string message) =>
        Console.WriteLine($"[Console] {message}");
}

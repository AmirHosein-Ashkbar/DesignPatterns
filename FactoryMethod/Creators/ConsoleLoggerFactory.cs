using FactoryMethod.Products;

namespace FactoryMethod.Creators;
public class ConsoleLoggerFactory : LoggerFactory
{
    public override ILogger CreateLogger() => new ConsoleLogger();
}

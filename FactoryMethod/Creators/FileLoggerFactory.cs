using FactoryMethod.Products;

namespace FactoryMethod.Creators;
public class FileLoggerFactory : LoggerFactory
{
    public override ILogger CreateLogger() => new FileLogger();

}

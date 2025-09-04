using FactoryMethod.Products;

namespace FactoryMethod.Creators;
public abstract class LoggerFactory
{
    public abstract ILogger CreateLogger();
}

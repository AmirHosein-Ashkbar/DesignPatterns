namespace FactoryMethod.Products;
public class FileLogger : ILogger
{
    public void Log(string message) =>
        File.AppendAllText("log.txt", $"{message} - {DateTime.Now}" + Environment.NewLine);
}

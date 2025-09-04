using FactoryMethod.Creators;

LoggerFactory factory;

// Use Console Logger
factory = new ConsoleLoggerFactory();
var consoleLogger = factory.CreateLogger();
consoleLogger.Log("Logging to console");

// Switch to File Logger
factory = new FileLoggerFactory();
var fileLogger = factory.CreateLogger();
fileLogger.Log("Logging to file");
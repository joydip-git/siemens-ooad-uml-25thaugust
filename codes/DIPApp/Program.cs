// See https://aka.ms/new-console-template for more information
using DIPApp;

Console.WriteLine("Hello, World!");

try
{
    int x = 10;
    int y = 0;
    int res = x / y;
    Console.WriteLine($"{res}");
}
catch (System.Exception ex)
{
    new ExceptionLoggerManager(new FileLogger()).LogException(ex);
}
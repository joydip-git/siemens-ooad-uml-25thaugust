// See https://aka.ms/new-console-template for more information
using OCPApp;

Console.WriteLine("Hello, World!");

AreaCalculator calculator = new AreaCalculator();
System.Console.WriteLine(calculator.CalculateShapeArea(new Circle { Radius = 12 }));
System.Console.WriteLine(calculator.CalculateShapeArea(new Square { Side = 12 }));

PersistenceManager manager = new PersistenceManager();
Action<string> saveMessagePrinter = (message) => System.Console.WriteLine(message);
manager.SaveData("gxaxkjAHXJKahkjxhAJKH", saveMessagePrinter);
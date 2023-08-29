// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var container = IOCConatiner.CreateContainer();
IPersistenceManager manager = container.Instantiate<IPersistenceManager, PersistanceManager>();

IBusinessComponent businessComponent = new BusinessComponent(manager);

businessComponent.FetchAll("da").ForEach(d => System.Console.WriteLine(d));





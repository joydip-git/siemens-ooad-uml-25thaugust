// See https://aka.ms/new-console-template for more information
using SRPApp;

Console.WriteLine("Hello, World!");

var people = new List<Person>
{
    new Person{Name="sunil", Location="Bangalore"},
    new Person{Name="anil", Location="Pune"},
    new Person{Name="Joydip", Location="Chennai"}
};

people.Sort(new PersonComparer(1));
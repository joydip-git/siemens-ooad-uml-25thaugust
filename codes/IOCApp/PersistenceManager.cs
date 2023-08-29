using IOCApp;

public class PersistanceManager : IPersistenceManager
{
    public bool Add(string data)
    {
        return true;
    }

    public List<string> GetAll()
    {
        return new List<string> { "data1", "data2" };
    }

    public List<Loan> getAllLoans()
    {
        return new List<Loan> { };
    }
}
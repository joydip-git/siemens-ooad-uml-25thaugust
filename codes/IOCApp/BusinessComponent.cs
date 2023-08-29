using IOCApp;

public class BusinessComponent : IBusinessComponent
{
    private IPersistenceManager manager;

    public BusinessComponent(IPersistenceManager manager)
    {
        this.manager = manager;
    }

    public List<string> FetchAll(string name)
    {
        return manager
        .GetAll()
        .Where(s => s.Contains(name))
        .ToList<string>();
    }

    public List<Loan> FetchAllLoans()
    {
        return manager.getAllLoans();
    }
}
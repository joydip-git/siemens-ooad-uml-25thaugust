using IOCApp;

public interface IPersistenceManager
{
    bool Add(string data);
    List<string> GetAll();
    List<Loan> getAllLoans();
}
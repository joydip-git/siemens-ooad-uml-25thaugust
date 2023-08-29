using IOCApp;

public interface IBusinessComponent
{
    List<string> FetchAll(string name);
    List<Loan> FetchAllLoans();
}
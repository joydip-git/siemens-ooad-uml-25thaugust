namespace CombinedFragment
{
    public class PersistenceManager
    {
        public List<Loan> GetAllLoans()
        {
            SqlDataReader reader = new SqlCommand().
            List < Loan > loanList = new List<Loan>();
            foreach (var item in loans)
            {
                loanList.Add(this.ConvertToLoan(item));
            }
            return loanList;
        }
        private Loan ConvertToLoan(Object obj)
        {
            return new Loan();
        }
    }
}
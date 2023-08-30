namespace CombinedFragment
{
    public class PersistenceManager : IDisposable
    {
        ~PersistenceManager()
        {
            //connection.Close();
        }

        public void Dispose()
        {
            //connection.Close();
        }


        public List<Loan> GetAllLoans()
        {
            SqlDataReader reader = new SqlCommand().ExecuteQuery();
            List<Loan> loanList = new List<Loan>();
            while (reader.Read())
            {
                loanList.Add(this.ConvertToLoan(reader));
            }
            return loanList;
        }
        private Loan ConvertToLoan(Object obj)
        {
            return new Loan();
        }
    }
}
namespace SRPApp
{
    public class PersonComparer : IComparer<Person>
    {
        private readonly int choice;

        public PersonComparer(int choice)
        {
            this.choice = choice;
        }

        public int Compare(Person? x, Person? y)
        {
            throw new NotImplementedException();
        }
    }
}
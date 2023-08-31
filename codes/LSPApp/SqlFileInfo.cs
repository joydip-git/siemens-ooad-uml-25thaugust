namespace LSPApp
{
    public class SqlFile : IReadOnlySqlFile, IWriteOnlySqlFile
    {
        public string? FilePath { get; set; }
        public string? FileText { get; set; }

        public string Read()
        {
            return "data";
        }

        public void Write(string text)
        {
            //code
        }
    }
}
namespace LSPApp
{
    public class SqlFileService
    {
        public string ReadFromFile(IReadOnlySqlFile sqlFile)
        //public string ReadFromFile(ReadOnlySqlFile sqlFile)
        {
            return sqlFile.Read();
        }

        public void WriteIntoFile(IWriteOnlySqlFile sqlFile, string data)
        //public void WriteIntoFile(WriteOnlySqlFile sqlFile, string data)
        {
            sqlFile.Write(data);
        }
    }
}
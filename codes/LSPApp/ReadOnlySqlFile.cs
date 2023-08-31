namespace LSPApp
{
    public class ReadOnlySqlFile : SqlFileInfo, IReadOnlySqlFile
    {
        public string Read()
        {
            return "";
        }
    }
}
namespace OCPApp
{
    public class PersistenceManager
    {
        // public void SaveData(Action<string> func)
        // {
        //     func("ashasxjasxjahaxkjah");
        // }
        public void SaveData(string data, Action<string> func)
        {
            using (StreamWriter writer = new(@""))
            {
                writer.WriteLine(data);
                writer.Flush();
                writer.Close();
                func("data saved successfully");
            }
        }
    }
}
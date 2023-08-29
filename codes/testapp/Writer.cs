public class Writer : IWriter
{
    private String data;

    public Writer(string data)
    {
        this.data = data;
    }

    public void WriteData(IStream stream)
    {

    }
}
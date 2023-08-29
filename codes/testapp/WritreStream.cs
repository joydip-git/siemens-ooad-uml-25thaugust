public class WriterStream : IStream
{
    public Stream CreateStream(string path)
    {
        return new FileStream(path, FileMode.OpenOrCreate);
    }
}
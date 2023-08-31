namespace OCPApp
{
    public class Square : IShape
    {
        public double Side { get; set; }
        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
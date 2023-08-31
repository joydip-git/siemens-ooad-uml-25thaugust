namespace OCPApp
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

    }
}
namespace OCPApp
{
    public class AreaCalculator
    {
        /*
        public double CalculateArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
        public double CalculateArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
        
        public double CalculateArea(Object shape)
        {
            double area = 0;
            if (shape is Rectangle rectangle)
            {
                // Rectangle rectangle = (Rectangle)shape;
                area = rectangle.Height * rectangle.Width;
            }
            if (shape is Circle circle)
            {
                area = circle.Radius * circle.Radius * Math.PI;
            }
            return area;
        }
        */
        public double CalculateShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
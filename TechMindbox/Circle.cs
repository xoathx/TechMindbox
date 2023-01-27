namespace TechMindbox
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Неверное значение радиуса.", nameof(radius));

            Radius = radius;
        }
        public double Radius { get; }


        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
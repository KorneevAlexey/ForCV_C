namespace ShapeAreaCalculator
{
    public interface IShape
    {
        double getArea();
    }

    public class Circle : IShape
    {
        private double Radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override bool Equals(object obj)
        {
            return obj is Circle round &&
                   Radius == round.Radius;
        }

        public double getArea()
        {
            return System.Math.PI * Radius * Radius;
        }

        public override int GetHashCode()
        {
            return 598075851 + Radius.GetHashCode();
        }
    }

    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new System.ArgumentException("Side not corret", "sideA");
            }
            if (sideB <= 0)
            {
                throw new System.ArgumentException("Side not corret", "sideB");
            }
            if (sideC <= 0)
            {
                throw new System.ArgumentException("Side not corret", "sideC");
            }
            if (!((sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB)))
            {
                throw new System.ArgumentException("It is not triangle");
            }

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double getArea()
        {
            double halfP = (sideA + sideB + sideC) / 2;
            return System.Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC));
        }

    }

    public class ShapeAreaCalculator
    {
        public static double TriangleArea(double sideA, double sideB, double sideC)
        {
            return (new Triangle(sideA, sideB, sideC)).getArea();
        }
        public static double CircleArea(double radius)
        {
            return (new Circle(radius)).getArea();
        }
        public static double ShapeArea(IShape shape)
        {
            return shape.getArea();
        }

    }
}

using SquareLibrary.Interfaces;

namespace SquareLibrary.Shapes
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            if (IsRightAngled(_sideA, _sideB, _sideC))
            {
                return CalculateRightAngledTriandleArea(_sideA, _sideB, _sideC);
            }
            return CalculateTriangleArea(_sideA, _sideB, _sideC);
        }

        private double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        private double CalculateRightAngledTriandleArea(double sideA, double sideB, double sideC)
        {
            double h = (Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) / (2 * sideA);
            return sideA * h / 2;
        }

        public bool IsRightAngled(double sideA, double sideB, double sideC)
        {
            return (sideA * sideA + sideB * sideB == sideC * sideC) ||
                   (sideA * sideA + sideC * sideC == sideB * sideB) ||
                   (sideB * sideB + sideC * sideC == sideA * sideA);
        }
    }
}

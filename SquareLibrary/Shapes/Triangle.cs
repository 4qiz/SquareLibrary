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
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        private double CalculateRightAngledTriandleArea(double sideA, double sideB, double sideC)
        {
            double h = (Math.Pow(_sideC, 2) - Math.Pow(_sideA, 2)) / (2 * _sideA);
            return _sideA * h / 2;
        }

        public bool IsRightAngled(double a, double b, double c)
        {
            return (a * a + b * b == c * c) ||
                   (a * a + c * c == b * b) ||
                   (b * b + c * c == a * a);
        }
    }
}

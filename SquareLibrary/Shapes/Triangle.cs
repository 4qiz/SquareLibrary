using SquareLibrary.Interfaces;

namespace SquareLibrary.Shapes
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        /// <summary>
        /// Инициализирует новый экземпляр класса Triangle с указанными сторонами
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        /// <exception cref="ArgumentException">Выбрасывается, если стороны треугольника не являются положительными числами или треугольник невозможно создать</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными числами");
            }

            if (CanTriangleExist(sideA, sideB, sideC))
            {
                throw new ArgumentException("Треугольник с заданными сторонами невозможно создать");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <summary>
        /// Проверяет, может ли треугольник с заданными сторонами существовать
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        /// <returns>True, если треугольник с заданными сторонами может существовать, в противном случае - false</returns>
        private static bool CanTriangleExist(double sideA, double sideB, double sideC)
        {
            return sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA;
        }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea()
        {
            if (IsRightAngled())
            {
                return CalculateRightAngledTriandleArea(_sideA, _sideB, _sideC);
            }
            return CalculateTriangleArea(_sideA, _sideB, _sideC);
        }

        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона (S = sqrt(p * (p - a) * (p - b) * (p - c))), 
        /// где S - площадь треугольника, p - полупериметр треугольника
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        /// <returns>Площадь треугольника</returns>
        private double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        /// <summary>
        /// Вычисляет площадь прямоугольного треугольника по формуле: S = 0.5 * катет1 * катет2.
        /// </summary>
        /// <param name="sideA">Длина стороны A.</param>
        /// <param name="sideB">Длина стороны B.</param>
        /// <param name="sideC">Длина стороны C. (Гипотенуза)</param>
        /// <returns>Площадь прямоугольного треугольника</returns>
        private double CalculateRightAngledTriandleArea(double sideA, double sideB, double sideC)
        {
            double cathetus1, cathetus2;

            if (sideA >= sideB && sideA >= sideC)
            {
                cathetus1 = sideB;
                cathetus2 = sideC;
            }
            else if (sideB >= sideA && sideB >= sideC)
            {
                cathetus1 = sideA;
                cathetus2 = sideC;
            }
            else
            {
                cathetus1 = sideA;
                cathetus2 = sideB;
            }
            return 0.5 * cathetus1 * cathetus2;
        }

        /// <summary>
        /// Определяет, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>True, если треугольник прямоугольный, в противном случае - false</returns>
        public bool IsRightAngled()
        {
            return (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC) ||
                   (_sideA * _sideA + _sideC * _sideC == _sideB * _sideB) ||
                   (_sideB * _sideB + _sideC * _sideC == _sideA * _sideA);
        }
    }
}

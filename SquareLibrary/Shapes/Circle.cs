using SquareLibrary.Interfaces;

namespace SquareLibrary.Shapes
{
    /// <summary>
    /// Представляет круг
    /// </summary>
    public class Circle : IShape
    {
        private readonly double _radius;

        /// <summary>
        /// Инициализирует новый экземпляр класса Circle с указанным радиусом
        /// </summary>
        /// <param name="radius">Радиус круга больше 0</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус меньше нуля</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Радиус не может быть меньше нуля");
            }
            _radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}

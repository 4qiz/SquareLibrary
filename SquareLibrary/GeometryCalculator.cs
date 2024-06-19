using SquareLibrary.Interfaces;

namespace SquareLibrary
{
    /// <summary>
    /// Класс для вычисления площади геометрических фигур
    /// </summary>
    public class GeometryCalculator
    {
        /// <summary>
        /// Вычисляет площадь переданной фигуры
        /// </summary>
        /// <param name="shape">Фигура, для которой нужно вычислить площадь</param>
        /// <returns>Значение площади указанной фигуры</returns>
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}

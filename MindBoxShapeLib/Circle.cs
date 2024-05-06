namespace MindBoxShapeLib;

/// <summary>
/// Фигура круга.
/// </summary>
public class Circle : Figure
{

    /// <summary>
    /// Радиус.
    /// </summary>
    public double Radius { get; private set; }

    public Circle() { }

    public Circle(double radius) : base()
    {
        if (radius <= 0) throw new ArgumentException("Введено неккоректное значение радиуса.");

        Radius = radius;
    }

    /// <summary>
    /// Вычисление площади круга.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public override double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }
}

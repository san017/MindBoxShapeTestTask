namespace MindBoxShapeLib;

/// <summary>
/// Фигура треугольник.
/// </summary>
public class Triangle : Figure
{
    /// <summary>
    /// Первая сторона.
    /// </summary>
    public double FirstSide { get; private set; }

    /// <summary>
    /// Вторая сторона.
    /// </summary>
    public double SecondSide { get; private set; }

    /// <summary>
    /// Третья сторона.
    /// </summary>
    public double ThirdSide { get; private set; }

    public Triangle() { }

    public Triangle(double firstSide, double secondSide, double thirdSide) : base()
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            throw new ArgumentException("Введенны неккоректные значения сторон треугольника.");

        if (firstSide > secondSide + thirdSide || secondSide > firstSide + thirdSide || thirdSide > firstSide + secondSide)
            throw new ArgumentException("Одна из сторон треугольника больше чем сумма двух других.Проверьте данные");

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    /// <summary>
    /// Площадь треугольника.
    /// </summary>
    /// <returns></returns>
    public override double CalculateSquare()
    {
        var p = (FirstSide + SecondSide + ThirdSide) / 2;

        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
    }

    /// <summary>
    /// Проверка на то, что треугольник является прямоугольным.
    /// </summary>
    /// <returns>true - треугольник прямоугольный, false - треугольник не прямоугольный.</returns>
    public bool IsRectangular()
    {
        return CheckSideTriangle(FirstSide, SecondSide, ThirdSide) ||
               CheckSideTriangle(SecondSide, FirstSide, ThirdSide) ||
               CheckSideTriangle(ThirdSide, FirstSide, SecondSide);
    }

    /// <summary>
    /// Проверка стороны, что треугольник прямоугольный.
    /// </summary>
    /// <param name="checkedSide">Проверяемая строна.</param>
    /// <param name="otherFirstSide">Первая другая сторона.</param>
    /// <param name="otherSecondSide">Вторая другая сторона.</param>
    /// <returns>true - сторона является суммой двух других. false - не является.</returns>
    private static bool CheckSideTriangle(double checkedSide, double otherFirstSide, double otherSecondSide)
    {
        return checkedSide == Math.Sqrt(otherFirstSide * otherFirstSide + otherSecondSide * otherSecondSide);
    }
}

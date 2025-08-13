namespace Problems.ChatGPT.GPT0002.TriangleArea;

public static class Solution
{
    /// <summary>
    /// Возвращает площадь треугольника по формуле Герона.
    /// </summary>
    public static double TriangleArea(double a, double b, double c)
    {
        if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c))
            throw new ArgumentException("Стороны должны быть числами.");
        if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), "Сторона должна быть > 0.");
        if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), "Сторона должна быть > 0.");
        if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c), "Сторона должна быть > 0.");

        if (!(a + b > c && a + c > b && b + c > a))
            throw new ArgumentException("Нарушено неравенство треугольника.");

        double halfP = (a + b + c) / 2.0;
        double s = Math.Sqrt(halfP*(halfP-a)*(halfP - b)*(halfP - c));
        return s;
    }
}

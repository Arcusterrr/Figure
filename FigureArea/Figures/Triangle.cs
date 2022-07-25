namespace FigureSquare.Figures
{
    public static class Triangle
    {
        /// <summary>
        /// плоащдь треугольника, зная все 3 стороны
        /// </summary>
        public static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Проверка треугольника на прямоугольный
        /// </summary>
        public static bool RightTriangle(double a, double b, double c)
        {
            if (c == Math.Sqrt(a * a + b * b)) return true;
            if (a == Math.Sqrt(c * c + b * b)) return true;
            if (b == Math.Sqrt(a * a + c * c)) return true;
            return false;
        }
    }
}

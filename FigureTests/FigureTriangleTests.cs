using FigureSquare.Figures;

namespace FigureTests
{
    [TestClass]
    public class FigureTriangleTests
    {
        [TestMethod]
        public void TriangleAreaTests()
        {
            double a = 13;
            double b = 12;
            double c = 5;
            double expected = 30;

            double result = Triangle.Square(a, b, c);

            Assert.AreEqual(expected, result, "Вычисление площади треугольника некорректный");
        }

        [TestMethod]
        public void RightTriangleTests()
        {
            double a = 13;
            double b = 12;
            double c = 5;
            bool expected = true;

            bool result = Triangle.RightTriangle(a, b, c);

            Assert.AreEqual(expected, result, "Проверка треугольника на прямоугольный неккоректа");
        }
    }
}
using FigureSquare.Figures;

namespace FigureTests
{
    [TestClass]
    public class FigureCircleTests
    {
        [TestMethod]
        public void CircleAreaTests()
        {
            double radius = 2;
            double expected = 12.566370614359172;

            double result = Circle.Square(radius);

            Assert.AreEqual(expected, result, "Вычисление площади круга неккоректно");
        }
    }
}

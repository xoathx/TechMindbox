namespace TechMindbox.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void SquareTest_10radius()
        {
            double expected = Math.PI * Math.Pow(10d, 2);

            Circle testCircle = new Circle(10d);
            double actual =  testCircle.GetSquare();

            Assert.AreEqual(expected, actual);

        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ShapeAreaLibrary;

namespace TestShapeArea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRectangle()
        {
            Rectangle r = new Rectangle(3, 4, 5);
            double rectArea = r.CalcArea();
            Assert.AreEqual(rectArea, 6);
        }
        [TestMethod]
        public void TestCircle()
        {
            Circle c = new Circle(8);
            double circArea = c.CalcArea();
            Assert.AreEqual(circArea, 200.96);
        }
    }
}

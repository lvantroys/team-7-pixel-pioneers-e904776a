using NUnit.Framework;
using levelup;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position();
        }

        [Test]
        public void positionTest()
        {
            int expecteedX = 1;
            int expectedY = 1;

            Point coordinates = testObj.PositionSet(expecteedX, expectedY);

            Assert.IsTrue(coordinates.X == expecteedX);
            Assert.IsTrue(coordinates.Y == expectedY);

        }
    }
}
using NUnit.Framework;
using levelup;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;
        public readonly int ARBITRARY_X_VALUE = 2;
        public readonly int ARBITRARY_Y_VALUE = 3;


        [SetUp]
        public void SetUp()
        {
            testObj = new Position(ARBITRARY_X_VALUE,ARBITRARY_Y_VALUE);
        }

        [Test]
        public void positionInitializationTest()
        {
            Assert.IsTrue(testObj?.getCoordinates().X == ARBITRARY_X_VALUE);
            Assert.IsTrue(testObj?.getCoordinates().Y == ARBITRARY_Y_VALUE);
        }
    }
}
using NUnit.Framework;
using levelup;
using System.Diagnostics.Contracts;
using System.IO.Pipes;


namespace levelup
{

    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testObjGameMap;
        public readonly int ARBITRARY_X_VALUE = 2;
        public readonly int ARBITRARY_Y_VALUE = 3;


        [SetUp]
        public void SetUp()
        {
            testObjGameMap = new GameMap();
        }

        [Test]
        public void GameMapInitializationTest()
        {
           #pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObjGameMap);
        }

        [Test]
        public void GetPositionsTest()
        {
         Assert.IsTrue(testObjGameMap.GetPositions().Length.Equals(100));
        }

        [Test]
        public void CalculatePositionTest()
        {
            Position calculatedPosition = testObjGameMap.calculatePosition(new Position (2,3), GameController.DIRECTION.NORTH);
            Position expectedCalculatedPosition = new Position(2,3);
            Assert.IsTrue(calculatedPosition.getCoordinates().Equals(expectedCalculatedPosition.getCoordinates()));
        }

         [Test]
        public void IsPositionValidTest()
        {
            Position positionToTest = new Position(0,0);
            Assert.IsFalse(testObjGameMap.isPositionValid(positionToTest.getCoordinates()));
        }

        [Test]
        public void GetTotalPositionsTest()
        {
            int totalPositionsPreMove = testObjGameMap.GetTotalPositions();
            Position calculatedPosition = testObjGameMap.calculatePosition(new Position (2,3), GameController.DIRECTION.NORTH);
            Position expectedCalculatedPosition = new Position(2,3);
            int totalPositionsPostMove = testObjGameMap.GetTotalPositions();
            Assert.IsTrue(totalPositionsPostMove == totalPositionsPreMove + 1);
        }
    }
}
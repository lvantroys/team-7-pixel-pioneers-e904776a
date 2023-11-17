using NUnit.Framework;
using levelup;
using System.Diagnostics.Contracts;


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
    }
}
using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObjGameController;
        private MockCharacter? mockCharacterObject;

        [SetUp]
        public void SetUp()
        {
            testObjGameController = new GameController();
            mockCharacterObject = new MockCharacter();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObjGameController.GetStatus());
        }

        [Test]
        public void testUpdateStatus()
        {
            testObjGameController.updateStatus(mockCharacterObject.getName(),
              mockCharacterObject.getPosition(),
              mockCharacterObject.getMaxCount());
            Assert.IsTrue(testObjGameController.GetStatus().characterName.Equals(mockCharacterObject.getName()));
            Assert.IsTrue(testObjGameController.GetStatus().currentPosition.Equals(mockCharacterObject.getPosition()));
            Assert.IsTrue(testObjGameController.GetStatus().moveCount.Equals(mockCharacterObject.getMaxCount()));
        }
    }
}
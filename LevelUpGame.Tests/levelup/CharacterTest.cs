using NUnit.Framework;
using levelup;


namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;
        private Character? testCustomObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
            testCustomObj = new Character ("Nicole");
        }

        [Test]
        public void IsCharacterInitializedwithDefaultName()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsTrue ("ChatGPT".Equals(testObj.getName()));
        }
        [Test]
        public void IsCharacterInitializedwithCustomizedName()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
             Assert.IsTrue ("Nicole".Equals(testCustomObj.getName()));
            
        }
    } 
}
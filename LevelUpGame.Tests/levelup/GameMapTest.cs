using NUnit.Framework;
using System.Drawing;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
            testObj.numPositions = 1;
        }

        [Test]
        public void IsGameResultInitialized()
        {
            #pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.numPositions);
        }
    }
}
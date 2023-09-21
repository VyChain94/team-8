using NUnit.Framework;
using System.Drawing;
using levelup;

namespace levelup
{
    [TestFixture]
    public class positionTest
    {
        private Position testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position();
        }

        [Test]
        public void IsGameResultInitialized()
        {
            Point testPoint = new Point(0, 1);   
            #pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.CurrentPosition(0, 1));
        }
    }
}
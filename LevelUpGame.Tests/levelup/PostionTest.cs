using NUnit.Framework;
using System.Drawing;
using levelup;

namespace levelup
{
    [TestFixture]
    public class positionTest
    {
        private position testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new position();
        }

        [Test]
        public void IsGameResultInitialized()
        {
            Point testPoint = new Point(0, 1);   
            #pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.Position(0, 1));
        }
    }
}
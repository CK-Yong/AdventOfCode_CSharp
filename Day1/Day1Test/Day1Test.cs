using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day1Tests
{
    [TestClass]
    public class Day1Test
    {
        private Walker walker = new Walker();

        [TestInitialize]
        public void reset()
        {
            walker.reset();
        }

        [TestMethod]
        public void parseR2L3ShouldGiveDistanceOf5()
        {
            walker.walk(new string[] { "R2", "L3" });
            Assert.AreEqual(5, walker.getDistance());
        }

        [TestMethod]
        public void turnLeftWalk100ShouldReturn100()
        {
            walker.walk(new string[] { "L100" });
            Assert.AreEqual(100, walker.getDistance());
        }
    }
}
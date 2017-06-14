using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day1Tests
{
    [TestClass]
    public class Day1Test
    {
        private Walker _walker = new Walker();

        [TestInitialize]
        public void Reset()
        {
            _walker.Reset();
        }

        [TestMethod]
        public void ParseR2L3ShouldGiveDistanceOf5()
        {
            _walker.Walk(new string[] { "R2", "L3" });
            Assert.AreEqual(5, _walker.GetDistance());
        }

        [TestMethod]
        public void TurnLeftWalk100ShouldReturn100()
        {
            _walker.Walk(new string[] { "L100" });
            Assert.AreEqual(100, _walker.GetDistance());
        }
    }
}
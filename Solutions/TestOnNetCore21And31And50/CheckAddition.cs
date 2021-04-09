using Microsoft.VisualStudio.TestTools.UnitTesting;

using NetStd20Lib;

namespace TestOnNetCore21And31And50
{
    [TestClass]
    public class CheckAddition
    {
        [TestMethod]
        public void SeemsLegit()
        {
            Assert.AreEqual(42, Calc.Add(21, 21));
            Assert.AreEqual(42, Calc.Add(14, 8));
        }
    }
}

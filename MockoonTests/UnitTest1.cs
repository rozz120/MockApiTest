using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MockoonTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = true;

            x.Should().BeTrue();
        }
    }
}

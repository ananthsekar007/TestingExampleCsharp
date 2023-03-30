using Microsoft.VisualStudio.TestPlatform.TestHost;
using TestingExample;

namespace TestProject_Case
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int sum = AddTest.Add(1, 2);
            Assert.AreEqual(sum, 3);
        }   
    }
}
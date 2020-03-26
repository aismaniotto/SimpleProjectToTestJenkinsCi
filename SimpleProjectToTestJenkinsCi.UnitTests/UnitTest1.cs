using NUnit.Framework;

namespace SimpleProjectToTestJenkinsCi.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // not setup
        }
        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(true); 
        }
    }
}
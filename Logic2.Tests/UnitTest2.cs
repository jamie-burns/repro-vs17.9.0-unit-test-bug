using Logic.Tests;

namespace Logic2.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var value = BaseLogic.GetConnectionString("DBContext2");
            Assert.IsNotNull(value);
        }
    }
}
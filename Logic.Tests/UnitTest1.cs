namespace Logic.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var value = BaseLogic.GetConnectionString("DBContext1");
            Assert.IsNotNull(value);
        }
    }
}
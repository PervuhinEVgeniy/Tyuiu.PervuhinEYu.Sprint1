using Tyuiu.PervuhinEYu.Sprint1.Task0.V13.Lib;
namespace Tyuiu.PervuhinEYu.Sprint1.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}

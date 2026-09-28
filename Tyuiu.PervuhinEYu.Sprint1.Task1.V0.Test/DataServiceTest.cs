using Tyuiu.PervuhinEYu.Sprint1.Task1.V6.Lib;

namespace Tyuiu.PervuhinEYu.Sprint1.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.0, res); 

        }
    }
}

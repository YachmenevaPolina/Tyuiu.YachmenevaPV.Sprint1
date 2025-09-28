using Tyuiu.YachmenevaPV.Sprint1.Task3.V4.Lib;
namespace Tyuiu.YachmenevaPV.Sprint1.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.75;
            double y = 0.5;
            int z = 7;
            double wait = 22.75;
            var res = ds.PurchaseAmount(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}

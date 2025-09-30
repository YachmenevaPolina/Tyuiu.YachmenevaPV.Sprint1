using Tyuiu.YachmenevaPV.Sprint1.Task5.V6.Lib;
namespace Tyuiu.YachmenevaPV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 58;
            DataService ds = new DataService();
            double res = ds.Calculate(k);

            int result = Convert.ToInt32(res);
            int wait = 2;
            Assert.AreEqual(wait, result);
        }
    }
}

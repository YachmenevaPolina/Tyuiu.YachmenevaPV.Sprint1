using Tyuiu.YachmenevaPV.Sprint1.Task6.V5.Lib;
namespace Tyuiu.YachmenevaPV.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "шалаш";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "шалаш";
            Assert.AreEqual(wait, res);
        }
    }
}

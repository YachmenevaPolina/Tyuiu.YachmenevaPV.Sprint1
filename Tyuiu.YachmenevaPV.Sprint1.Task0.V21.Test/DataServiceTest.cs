﻿using Tyuiu.YachmenevaPV.Sprint1.Task0.V21.Lib;
namespace Tyuiu.YachmenevaPV.Sprint1.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(17, res);
        }
    }
}

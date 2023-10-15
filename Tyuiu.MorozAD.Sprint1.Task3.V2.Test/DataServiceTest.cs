using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MorozAD.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            int x1 = 1;
            double y = 2;
            int y1 = 2;
            var res = ds.PurchaseAmount(x, x1, y, y1);
            Assert.AreEqual(5, res);
        }
    }
}

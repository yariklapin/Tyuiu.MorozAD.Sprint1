using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint1.SprintReview.V14.Lib;

namespace Tyuiu.MorozAD.Sprint1.SprintReview.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint1.Task2.V12.Lib;

namespace Tyuiu.MorozAD.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            int z = 3;
            var res = ds.CalculateParallelepipedVolume(x, y, z);
            Assert.AreEqual(6, res);
        }
    }
}

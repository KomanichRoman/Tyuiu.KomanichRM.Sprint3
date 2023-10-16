using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint2.Task0.V27.Lib;

namespace Tyuiu.KomanichRM.Sprint2.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double k = 5;
            int n = 1;
            int h = 14;
            double res = ds.GetSumSeries(k,n,h);
            double wait = 16.016;
            Assert.AreEqual(res, wait);

        }
    }
}

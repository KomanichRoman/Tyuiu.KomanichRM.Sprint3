using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint2.Task0.V27.Lib;

namespace Tyuiu.KomanichRM.Sprint2.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumOfRows()
        {
            DataService ds = new DataService();
            double k = 1;
            double n = 5;
            double res = ds.SumOfRows(k, n);
            double wait = 16.016;
            Assert.AreEqual(res, wait);

        }
    }
}

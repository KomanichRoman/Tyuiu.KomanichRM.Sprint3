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
            double value = 5;
            int startValue = 1;
            int stopValue = 14;
            double res = ds.GetSumSeries(value,startValue,stopValue);
            double wait = 16.016;
            Assert.AreEqual(res, wait);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint3.Task2.V22.Lib;

namespace Tyuiu.KomanichRM.Sprint3.Task2.V22.Test
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
            int stopValue = 7;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.125;
            Assert.AreEqual(wait, res);
        }
    }
}

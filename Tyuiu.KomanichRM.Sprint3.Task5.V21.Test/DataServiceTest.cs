using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint3.Task5.V21.Lib;

namespace Tyuiu.KomanichRM.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeriesValid()
        {
            DataService ds = new DataService();
            int x = 2;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 10;
            double res = ds.GetSumSumSeries(x, start1, stop1, start2, stop2);
            double wait = 3.667;
            Assert.AreEqual(res, wait);
        }
    }
}

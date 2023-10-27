using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint3.Task6.V14.Lib;

namespace Tyuiu.KomanichRM.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 7;
            int stop = 16;
            int res = ds.GetSumTheDivisors(start, stop);
            int wait = 5;
            Assert.AreEqual(res, wait);
        }
    }
}

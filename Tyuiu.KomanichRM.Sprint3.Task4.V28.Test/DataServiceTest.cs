﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint3.Task4.V28.Lib;

namespace Tyuiu.KomanichRM.Sprint3.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 1.924;
            Assert.AreEqual(res, wait);
        }
    }
}

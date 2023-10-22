using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint3.Task3.V27.Lib;

namespace Tyuiu.KomanichRM.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidonvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "!bt, g567kid f!";
            int res = ds.ConvertStringToInt(value);
            int wait = 567;
            Assert.AreEqual(wait, res);
        }
    }
}

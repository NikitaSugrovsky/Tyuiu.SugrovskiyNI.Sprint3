using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint3.Task1.V12.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 2.001;

            Assert.AreEqual(wait, res);
        }
    }
}

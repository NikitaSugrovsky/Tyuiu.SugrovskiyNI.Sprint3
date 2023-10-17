using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint3.Task0.V2.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        static void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 27.866;

            Assert.AreEqual(wait, res);
        }
    }
}

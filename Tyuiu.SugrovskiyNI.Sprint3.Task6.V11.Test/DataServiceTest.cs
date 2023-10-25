﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint3.Task6.V11.Lib;
namespace Tyuiu.SugrovskiyNI.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stoptValue = 19;

            double res = ds.GetSumTheDivisors(startValue, stoptValue);
            double wait = 228;

            Assert.AreEqual(wait, res);


        }
    }
}

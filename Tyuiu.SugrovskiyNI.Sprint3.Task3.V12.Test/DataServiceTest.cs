using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint3.Task3.V12.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMaxCharCount()
        {
            DataService ds = new DataService();

            string value = "bkkrk ckkkcs ksr";
            char item = 'k';

            int res = ds.GetMaxCharCount(value, item);

            int wait = 7;

            Assert.AreEqual(wait, res);




        }
    }
}

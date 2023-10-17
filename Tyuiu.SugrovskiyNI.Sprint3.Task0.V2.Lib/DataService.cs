using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task0.V2.Lib
{
    [TestClass]
    public class DataService : ISprint3Task0V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = 9 * i * Math.Sin(1) - 2 * i;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
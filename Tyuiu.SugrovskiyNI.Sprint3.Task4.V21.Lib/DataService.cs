using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task4.V21.Lib
{
    public class DataService : ISprint3Task4V21
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1; //  1, так как начинаем с умножения
            for (int x = startValue; x <= stopValue; x++) 
            {
                if (x == 0)
                {
                    continue; // continue, чтобы пропустить x = 0
                }
                else
                {
                    res *= (Math.Cos(x) - x) / x; 
                }
            }
            return Math.Round(res, 3);
        }
    }
}

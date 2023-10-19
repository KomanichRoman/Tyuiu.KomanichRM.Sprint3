using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomanichRM.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 1;
            do
            {
                SumSeries *= Math.Pow((3 / (startValue + Math.Pow(value, (startValue * (-1))))), 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}

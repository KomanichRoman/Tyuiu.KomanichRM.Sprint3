using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KomanichRM.Sprint2.Task0.V27.Lib
{
    public class DataService
    {
        public double SumOfRows(double k, double n)
        {
            double res = 0;
            for (k = 1; k < 14; k++)
            {
                res += Math.Pow((4 / (Math.Pow(k, n))),2);
            }
            return Math.Round(res,3);
        }
    }
}

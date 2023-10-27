using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomanichRM.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int count1 = 0;
            int count2 = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (x % j == 0) 
                    {
                        if (j > 5)
                        {
                            count2++;
                        }
                    }
                }
                if (count2 > 5)
                {
                    count1++;
                }
            }
            return count1;
        }
    }
}

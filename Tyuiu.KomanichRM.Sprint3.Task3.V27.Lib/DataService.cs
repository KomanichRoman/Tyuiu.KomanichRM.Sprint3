using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KomanichRM.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            foreach (char chr in value)
            {
                if ((chr == '!') || (chr == 'b') || (chr == 't') || (chr == ',') || (chr == 'g') || (chr == 'k') || (chr == 'i') || (chr == 'd') || (chr == 'f'))
                {
                    value = value.Replace(chr, ' ');
                }
            }
            return Convert.ToInt32(value);
        }
    }
}

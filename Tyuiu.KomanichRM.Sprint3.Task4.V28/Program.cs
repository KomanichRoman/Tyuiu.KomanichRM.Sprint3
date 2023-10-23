using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomanichRM.Sprint3.Task4.V28.Lib;

namespace Tyuiu.KomanichRM.Sprint3.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Команич Р. М. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Команич Роман Маркович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                        *");
            Console.WriteLine("* вычислить значение функции y=(cos(x)+sin(x))/x                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Функция: y=(cos(x)+sin(x))/x                                              ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint3.Task5.V3.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                  *");
            Console.WriteLine("* Вложенные циклы                                                            *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #3                                                                 *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Найти                                                                      *");
            Console.WriteLine("* Сумма сумм рада                                                           * ");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 3;
            int stopValue1 = 1;
            int stopValue2 = 11;



            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы рада  = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы рада = " + startValue2);
            Console.WriteLine("Конец шага второго суммы рада = " + stopValue2);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Сумма сумм рада = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}

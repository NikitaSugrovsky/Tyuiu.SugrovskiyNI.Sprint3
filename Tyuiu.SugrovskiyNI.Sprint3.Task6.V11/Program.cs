using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint3.Task6.V11.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
                DataService ds = new DataService();

                Console.Title = "Спринт #3 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("* Спринт #3                                                                  *");
                Console.WriteLine("* Обработка целочисленной информации                                         *");
                Console.WriteLine("* Задание #6                                                                 *");
                Console.WriteLine("* Вариант #11                                                                *");
                Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                           *");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                   *");
                Console.WriteLine("* Программа, которая ищет среди целых чисел, принадлежащих числовому отрезку *");
                Console.WriteLine("* [10, 19] количество всех делителей больше 10                              * ");
                Console.WriteLine("*                                                                            *");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
                Console.WriteLine("******************************************************************************");

                int startValue = 10;
                int stoptValue = 19;



                Console.WriteLine("Начало отрезка = " + startValue);
                Console.WriteLine("Конец отрезка = " + stoptValue);


                Console.WriteLine("******************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
                Console.WriteLine("******************************************************************************");

                Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stoptValue));

                Console.ReadKey();
            }
    }
}

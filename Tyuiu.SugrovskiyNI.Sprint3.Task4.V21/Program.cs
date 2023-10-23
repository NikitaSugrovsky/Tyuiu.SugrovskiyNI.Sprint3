using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint3.Task4.V21.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint3.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                  *");
            Console.WriteLine("* Использование операторов continue и break в циклах                         *");
            Console.WriteLine("* Задание #4                                                                 *");
            Console.WriteLine("* Вариант #21                                                                *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение        *");
            Console.WriteLine("* функции y=(cos(x)-x)/x.При х = 0 пропустить значение.Значения перемножить * ");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.Write("Введите значение переменной StartValue:  ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение переменной StopValue:  ");
            int stopValue = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}

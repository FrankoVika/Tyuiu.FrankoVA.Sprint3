using Tyuiu.FrankoVA.Sprint3.Task7.V27.Lib;
namespace Tyuiu.FrankoVA.Sprint3.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [17, 26] сумму всех делителей                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага:  " + startValue);
            Console.WriteLine("Конец шага:  " + stopValue);

            int len= ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d} |{1,5:f2}|  " , startValue, valueArray[i]);
                startValue++;
            }

           
            Console.ReadKey();
        }
    }
}

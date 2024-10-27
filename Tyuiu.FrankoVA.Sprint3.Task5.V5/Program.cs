using Tyuiu.FrankoVA.Sprint3.Task5.V5.Lib;
namespace Tyuiu.FrankoVA.Sprint3.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* при Х=5                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            Console.WriteLine("Переменная Х:  " + x);
            Console.WriteLine("Старт шага первой суммы ряда:  " + startValue1);
            Console.WriteLine("Стоп шага первой суммы ряда:  " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда:  " + startValue2);
            Console.WriteLine("Стоп шага второй суммы ряда:  " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда:  " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}

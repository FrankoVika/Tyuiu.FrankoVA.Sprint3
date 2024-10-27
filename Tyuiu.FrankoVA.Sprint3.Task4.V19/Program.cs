using Tyuiu.FrankoVA.Sprint3.Task4.V19.Lib;
namespace Tyuiu.FrankoVA.Sprint3.Task4.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=x/(cos(x) + x)+0.5\r\n\r\nПри х = 0 прервать цикл.            *");
            Console.WriteLine("* Полученные значения перемножать.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага:  " + startValue);
            Console.WriteLine("Стоп шага:  " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда:  " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}

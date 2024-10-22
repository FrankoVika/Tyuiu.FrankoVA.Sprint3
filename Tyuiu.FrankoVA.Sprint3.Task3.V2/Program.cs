using Tyuiu.FrankoVA.Sprint3.Task3.V2.Lib;
namespace Tyuiu.FrankoVA.Sprint3.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв z,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: asdzzz vfvfzz v gthvz        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string value = "asdzzz vfvfzz v gthvz";
            char chr = 'z';
            
            Console.WriteLine("Исходная строка:  " + value);
            Console.WriteLine("Искомый символ:  " + chr);
          
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов:  " + ds.GetMaxCharCount(value, chr));
            Console.ReadKey();
        }
    }
}

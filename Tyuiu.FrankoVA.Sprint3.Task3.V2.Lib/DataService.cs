using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FrankoVA.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            foreach (char chr in value)
            {
                if (chr==item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

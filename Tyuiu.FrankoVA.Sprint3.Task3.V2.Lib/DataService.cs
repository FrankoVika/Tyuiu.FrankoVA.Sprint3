﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FrankoVA.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            
            int maxCount = 0;
            int currentCount = 0;

            foreach (char chr in value)
            {
                if (chr == item)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0; 
                }
            }

            return maxCount;
        }
    }
}

﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round(Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x, 2);
                    valueArray[count] = y;
                    count++;
                }

            }
            return valueArray;
        }
    }
}

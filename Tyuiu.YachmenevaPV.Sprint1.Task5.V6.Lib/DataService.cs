﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.YachmenevaPV.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int res = Convert.ToInt32((k - 1) % 7 + 1);
            return res;
        }
    }
}

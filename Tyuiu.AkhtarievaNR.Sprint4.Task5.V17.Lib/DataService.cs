﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task5V17
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}

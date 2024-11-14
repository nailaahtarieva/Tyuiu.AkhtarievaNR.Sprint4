using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;

            int maxi = int.MinValue;

            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i,j] > maxi)
                    {
                        maxi = array[i,j];
                    }
                }
            }
            return maxi;
        }
    }
}

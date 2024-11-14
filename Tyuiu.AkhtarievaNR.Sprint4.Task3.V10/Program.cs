using Tyuiu.AkhtarievaNR.Sprint4.Task3.V10.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 5, 7, 6, 6, 5 }, { 5, 5, 5, 4, 6 }, { 8, 5, 7, 4, 7 }, { 7, 6, 7, 4, 7 }, { 5, 8, 7, 8, 8 } };
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Ахтариева Н. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание: 3                                                              *");
            Console.WriteLine("* Вариант: 10                                                             *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет максимальное число в третьей      *");
            Console.WriteLine("* строке двумерного массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

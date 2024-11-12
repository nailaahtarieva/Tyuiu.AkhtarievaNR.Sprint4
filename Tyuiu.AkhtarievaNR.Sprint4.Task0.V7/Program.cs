using Tyuiu.AkhtarievaNR.Sprint4.Task0.V7.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Ахтариева Н. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание: 0                                                              *");
            Console.WriteLine("* Вариант: 7                                                              *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая подсчитать произведение                     *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsarray = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= numsarray.Length - 1; i++)
            {
                Console.WriteLine(numsarray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение нечетных элементов массива: ");

            int numres;
            numres = ds.GetMultOddArrEl(numsarray);

            Console.Write(numres);
            Console.ReadKey();
        }
    }
}

using Tyuiu.AkhtarievaNR.Sprint4.Task1.V13.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task1.V13
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
            Console.WriteLine("* Задание: 1                                                              *");
            Console.WriteLine("* Вариант: 13                                                             *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая подсчитывает сумму четных элементов массива *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsarray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение: " + i + " элемента массива: ");
                numsarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsarray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            int res = ds.Calculate(numsarray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

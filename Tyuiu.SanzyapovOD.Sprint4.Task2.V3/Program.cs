using Tyuiu.SanzyapovOD.Sprint4.Task2.V3.Lib;
namespace Tyuiu.SanzyapovOD.Sprint4.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант 3                                                               *");
            Console.WriteLine("* Выполнил: Санзяпов Олег Дмитриевич| ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от2до7 подсчитать сумму четных элементов массива *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 7);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsArray);
            Console.WriteLine("Сумма четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}

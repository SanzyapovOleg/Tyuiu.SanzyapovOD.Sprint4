using Tyuiu.SanzyapovOD.Sprint4.Task0.V9.Lib;
namespace Tyuiu.SanzyapovOD.Sprint4.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Санзяпов Олег Дмитриевич| ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
            Console.WriteLine("* четных элементов массива.  { 4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] numsarray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsarray.Length - 1; i++)
            {
                Console.WriteLine(numsarray[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма четных элементов:  " + ds.GetSumEvenArrEl(numsarray));
        }
    }
}

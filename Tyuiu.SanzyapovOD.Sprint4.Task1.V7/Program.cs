﻿using Tyuiu.SanzyapovOD.Sprint4.Task1.V7.Lib;
namespace Tyuiu.SanzyapovOD.Sprint4.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Санзяпов Олег Дмитриевич| ИСТНб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать сумму          *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsArry = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsArry);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

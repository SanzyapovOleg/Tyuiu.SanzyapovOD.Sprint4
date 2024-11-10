using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SanzyapovOD.Sprint4.Task2.V3.Lib
{
    public class DataService : ISprint4Task2V3
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sumArray += num;
                }
            }
            return sumArray;
        }
    }
}

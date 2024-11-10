using Tyuiu.SanzyapovOD.Sprint4.Task5.V28.Lib;
namespace Tyuiu.SanzyapovOD.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[,] { { 1, 2, 1, 1, -2 }, { 1, 2, 1, 1, -2 }, { 1, 2, 1, 1, 1 }, { 1, 2, 1, 1, 1 }, { 1, 2, 1, 1, 1 } };
            int[,] result = new int[,] { { 1, 2, 1, 1, 0 }, { 1, 2, 1, 1, 0 }, { 1, 2, 1, 1, 1 }, { 1, 2, 1, 1, 1 }, { 1, 2, 1, 1, 1 } };
            CollectionAssert.AreEqual(result, ds.Calculate(array));
        }
    }
}
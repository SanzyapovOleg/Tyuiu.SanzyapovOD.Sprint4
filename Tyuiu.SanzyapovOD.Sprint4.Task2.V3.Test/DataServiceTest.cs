using Tyuiu.SanzyapovOD.Sprint4.Task2.V3.Lib;
namespace Tyuiu.SanzyapovOD.Sprint4.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int[] a = new int[] { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };
            int res = dt.Calculate(a);
            Assert.AreEqual(res, 20);
        }
    }
}
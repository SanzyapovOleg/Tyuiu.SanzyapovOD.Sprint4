using Tyuiu.SanzyapovOD.Sprint4.Task6.V30.Lib;
namespace Tyuiu.SanzyapovOD.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "������", "���", "���", "�����", "�����", "�����" };
            string[] res = ds.Calculate(array);
            string[] wait = { "������" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
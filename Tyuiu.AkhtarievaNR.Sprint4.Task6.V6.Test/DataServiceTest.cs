using Tyuiu.AkhtarievaNR.Sprint4.Task6.V6.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var name = new string[] { "�����", "����", "������", "�����", "������", "�������", "����" };
            string[] res = ds.Calculate(name);
            string[] wait = { "�����", "�����" };
        }
    }
}
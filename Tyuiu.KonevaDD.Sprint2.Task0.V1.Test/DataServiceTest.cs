using Tyuiu.KonevaDD.Sprint2.Task0.V1.Lib;
namespace Tyuiu.KonevaDD.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 233;
            int y = 122;
            bool[] expected = new bool[6] { true, false, true, false, true, false};

            bool[] result = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(expected, result);

        }
    }
}
using Tyuiu.KonevaDD.Sprint2.Task6.V15.Lib;
namespace Tyuiu.KonevaDD.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("�����������", ds.FindDayName(8));
            Assert.AreEqual("�������", ds.FindDayName(9));
            Assert.AreEqual("�����", ds.FindDayName(10));
            Assert.AreEqual("�������", ds.FindDayName(11));
            Assert.AreEqual("�������", ds.FindDayName(12));
            Assert.AreEqual("�������", ds.FindDayName(13));
            Assert.AreEqual("�����������", ds.FindDayName(14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
        }
    }
}
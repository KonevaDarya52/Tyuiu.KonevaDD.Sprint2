using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonevaDD.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x - 111 == y;
            res[1] = x - 111 != y;
            res[2] = x / 2 < y;
            res[3] = x - 144 > y;

            res[4] = x + 11 <= y * 2;
            res[5] = x * 10 >= y / 122;

            return res;
        }
    }
}

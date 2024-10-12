using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonevaDD.Sprint2.Task1.V15.Lib
{
    
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c < d);
            res[1] = (a + 2 > b) & (c < d);
            res[2] = (a > b) || (c > d * 5);
            res[3] = (a > b * 2) && (c < d);
            res[4] = !res[0];
            res[5] = (a + 2 > b) ^ (c > d);

            return res;
        }
    }
}







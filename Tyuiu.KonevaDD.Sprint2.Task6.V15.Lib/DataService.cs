using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonevaDD.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int value)
        {
            switch (value % 7)
            {
                case 0: return "Воскресенье";
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                default: throw new ArgumentException("Проверьте корректность данных!"); ;
            }
        }



    }
}
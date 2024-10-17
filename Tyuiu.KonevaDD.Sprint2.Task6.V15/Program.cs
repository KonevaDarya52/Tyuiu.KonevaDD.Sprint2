using Tyuiu.KonevaDD.Sprint2.Task6.V15.Lib;
namespace Tyuiu.KonevaDD.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2| Выполнила: Конева Д.Д. | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Конева Дарья Денисовна | АСОиУБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращённую форму switch         *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
            Console.WriteLine("* недели (понедельником, вторником, …, субботой или воскресеньем)         *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января понедельник.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine(" Введите значение K: ");
            int k = Convert.ToInt16(Console.ReadLine());


            string res = ds.FindDayName(k);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
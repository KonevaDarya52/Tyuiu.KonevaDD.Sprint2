﻿using Tyuiu.KonevaDD.Sprint2.Task3.V8.Lib;
namespace Tyuiu.KonevaDD.Sprint2.Task3.V8
{
    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Конева Д. Д. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Конева Дарья Денисовна | АСОиУБ-24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
        Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
        Console.WriteLine("* значение переменной X с клавиатуры. Округлить до 3х знаков после запятой*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;

        Console.WriteLine("Введите значение переменной x: ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Значение функции равно: " + ds.Calculate(x));
    }
}
}
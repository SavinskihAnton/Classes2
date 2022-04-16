//Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
//и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
//Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в гривну.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.rub = rub;
            this.usd = usd;
            this.eur = eur;
        }
        public double ToUsd(double griv)
        { 
            return usd*griv;
        }
        public double ToEur(double griv)
        {
            return eur * griv;
        }
        public double ToRub(double griv)
        {
            return rub * griv;
        }
        public double ToGrivFromUsd(double griv)
        {
            return griv / usd;
        }
        public double ToGrivFromEur(double griv)
        {
            return griv / eur;
        }
        public double ToGrivFromRub(double griv)
        {
            return griv / rub;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter conv = new Converter(50, 65, 3);
            Console.WriteLine(conv.ToUsd(1.45));
            Console.WriteLine(conv.ToEur(2));
            Console.WriteLine(conv.ToRub(3.7));
            Console.WriteLine("-",30);
            Console.WriteLine(conv.ToGrivFromUsd(1));
            Console.WriteLine(conv.ToGrivFromEur(2));
            Console.WriteLine(conv.ToGrivFromRub(3.8));
            Console.ReadKey();
        }
    }
}

//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
//инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
//сбор.
//Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
//оклад и налоговый сбор.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Employee
    {
        readonly string name, familyname;
        int experiance;
        string post;

        public string Familyname { get { return familyname; } }
        public string Name { get { return name; } }
        public string Post 
        {
            get
            {
                if (post == null)
                    return "Нет такой должности";
                return post;
            }
            set
            {
                if (value!=null)
                post = value;

            }
        }
        public int Experiance
        {
            get
            {
                return experiance;
            }
            set
            {
                if (value >=0)
                    experiance = value;

            }
        }
        public Employee()
        {

        }
        public Employee(string name, string familyname)
        {
            this.name = name;
            this.familyname = familyname;
        }
        public double CountSalary()
        {
            double salarykoef;
            switch (post)// Должность
            { 
            case "manager": salarykoef = 100000;
                    break;
            case "developer": salarykoef = 75000;
                    break;
            case "secretary": salarykoef = 50000;
                    break;
            case "cleaner": salarykoef = 25000;
                    break;
            default: salarykoef = 10000;
                    break;
            }
            switch (experiance)// Опыт
            { 
            case 0: 
                    salarykoef *= 1.5;
                    break;
            case 1:
                    salarykoef *= 2;
                    break;
            case 2:
                    salarykoef *= 2.5;
                    break;
            default:
                    salarykoef *= 5;
                    break;
            }
            return salarykoef;
        }
        public void ShowSalary()
        {
            Console.WriteLine("Зарплата {0}, Подоходный налог {1}", CountSalary(), CountSalary()*0.13);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Anton","Savinskih");
            employee.Post = "manager";
            employee.Experiance = 2;
            employee.ShowSalary();
            Console.ReadKey();
        }
    }
}

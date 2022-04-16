//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
//заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
//(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonAdvanced
{
    class User
    {
        public string login, name, lastname;
        public int age;
        public readonly DateTime date;

        public User()
        {
            date = DateTime.Now;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.login = "Login";
            user.name = "name";
            user.lastname = "LastName";
            user.age = 22;

            Console.WriteLine(user.date);
            Console.WriteLine(user.login);
            Console.WriteLine(user.name);
            Console.WriteLine(user.lastname);
            Console.WriteLine(user.age);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Day_1
{
    internal class Day_1
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            string a = "Hello";
            string b = "world";

            Console.WriteLine(a + b + '\n');
          

            //Задание 2
            Console.WriteLine("Задание 2");
            double x = 5;
            double y = 3;

            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y );
            

            //Задание 3
            Console.WriteLine('\n' + "Задание 3");
            Console.WriteLine("Введите имя:" );
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string patronymic = Console.ReadLine();
            Console.WriteLine("\n" + $"имя  {name} фамилия {surname} отчество {patronymic}");

            //Задание 4
            Console.WriteLine("\n" + "Задание 4");
            double healthP = 100;
            double damageP = 5;
            double protectionP = 10;
            double healthM = 200;
            double damageM = 10;
            double protectionM = 15;

            double healthplayer = damageM / protectionP;
            double healthMonster = damageP / protectionM;
            Console.WriteLine('\n' + $"осталось зоровья у игрока: {healthplayer}, осталось здоровья у монстра: {healthMonster}, игрок нанес: {damageP} урона, монстер нанес: {damageM} урона");
            Console.ReadKey();
        }
    }
}
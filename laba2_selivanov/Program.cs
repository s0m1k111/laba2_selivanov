using System;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /*
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0) {
                Console.WriteLine("Оно чётное");
            }
            else {
                Console.WriteLine("Не чётное");
            }
            */

            //Задание 2
            /*
            Console.Write("Введите pass: ");
            string? a = Convert.ToString(Console.ReadLine());
            Console.Write("Повторите pass: ");
            string? b = Convert.ToString(Console.ReadLine());
            if (a==b) {
                Console.WriteLine("Пароль принят");
            }
            else {
                Console.WriteLine("Пароль не принят");
            }
            */

            //Задание 3
            /*
            Console.Write("Введите четырёхзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 1000 && a <= 9999) {
                int b = a / 1000;
                int c = (a / 100) % 10;
                int d = (a / 10) % 10;
                int f = a % 10;

                if (b + f == c - d) {
                    Console.WriteLine("ДА");
                }
                else {
                    Console.WriteLine("Нет");
                }
            }
            else {
                Console.WriteLine("Число не четырёхзначное");
            }
            */

            //Задание 4
            /*
            Console.Write("Введите возрост: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>=18) {
                Console.WriteLine("Доступ разрешен");
            }
            else {
                Console.WriteLine("Доступ запрещен");
            }
            */

            /*
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a>b) {
                Console.WriteLine(b);
            }
            else {
                Console.WriteLine(a);
            }
            */

            //Задание 6
            /*
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знак: ");
            string? znak = Convert.ToString(Console.ReadLine());
            switch (znak) {
                case "+":
                    Console.WriteLine($"{num}+{num1}={num + num1}");
                    break;
                case "-":
                    Console.WriteLine($"{num}-{num1}={num - num1}");
                    break;
                case "*":
                    Console.WriteLine($"{num}*{num1}={num * num1}");
                    break;
                case "/":
                    Console.WriteLine($"{num}/{num1}={num / num1}");
                    break;
            }
            */

            //Задание 7
            /*
            Console.Write("Введите день недели: ");
            int den_nedeli = Convert.ToInt32(Console.ReadLine());
            switch(den_nedeli)
            {
                case 1:
                    Console.WriteLine("Понедельник");break;
                case 2:
                    Console.WriteLine("Вторник");break;
                case 3:
                    Console.WriteLine("Среда"); break;
                case 4:
                    Console.WriteLine("Четверг"); break;
                case 5:
                    Console.WriteLine("Пятница"); break;
                case 6:
                    Console.WriteLine("Суббота"); break;
                case 7:
                    Console.WriteLine("Воскресенье"); break;
                default: 
                    Console.WriteLine("Балбес");
                    break;
            }
            */

            //Задание 8
            /*
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знак: ");
            string? znak = Convert.ToString(Console.ReadLine());
            switch (znak)
            {
                case "+":
                    Console.WriteLine($"{num}+{num1}={num + num1}");
                    break;
                case "-":
                    Console.WriteLine($"{num}-{num1}={num - num1}");
                    break;
                case "*":
                    Console.WriteLine($"{num}*{num1}={num * num1}");
                    break;
                case "/":
                    Console.WriteLine($"{num}/{num1}={num / num1}");
                    break;
                default: Console.WriteLine("Такого нету");break;
            }
            */

            //Задание 9
            /*
            Console.WriteLine("┌──────────────────────────┐");
            Console.WriteLine("│   Выбор сложности игры   │");
            Console.WriteLine("└──────────────────────────┘");

            Console.Write("Введите цифру (1-3): ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("│  ====)-------------  Лёгкая сложность   │");
                    break;
                case 2:
                    Console.WriteLine("│      /| ________________\r\nО|===|* >________________>\r\n      \\|   Средняя сложность  │");
                    break;
                case 3:
                    Console.WriteLine("│           />_________________________________\r\n[########[]_________________________________>\r\n         \\>  Сложная сложность  │");
                    break;
                default:
                    Console.WriteLine("│  ❗  Неверный ввод      │");
                    break;
            }
            */

            //Задание 10
            /*
             using System; подключаем базовые классы

                namespace Program объявляем пространство имени
                {
                    internal class Program Создание класса Program
                    {
                        static int health = 100; статичный инт для хранения хп
        
                        static void Main(string[] args) главный метод проги
                        {
                            Console.WriteLine($"Здоровье персонажа: {health}"); вывод здоровья
                            TakeDamage(30); вызов метода который отвечает за -хп
                        }
        
                        static void TakeDamage(int damage) метод который отвечает за -хп
                        {
                            health -= damage; минусуем хп
                            Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}."); выводим инфу что чел получил -хп
                        }
                    }
                }
            */

            //Задание 11
            /*
            Console.Write("Введите класс перса (воин,маг,разбойник,паладин,варвар,охотник,друид,жрец): ");
            string? clasik = Convert.ToString(Console.ReadLine()).ToLower();
            switch (clasik)
            {
                case "воин":
                    Console.WriteLine("ближний боец"); break;
                case "маг":
                    Console.WriteLine("дальный боец"); break;
                case "разбойник":
                    Console.WriteLine("ближний боец"); break;
                case "паладин":
                    Console.WriteLine("дальный боец"); break;
                case "варвар":
                    Console.WriteLine("ближний боец"); break;
                case "охотник":
                    Console.WriteLine("ближний боец"); break;
                case "друид":
                    Console.WriteLine("ближний боец"); break;
                case "жрец":
                    Console.WriteLine("дальный боец"); break;
                default:
                    Console.WriteLine("Балбес");
                    break;
            }
            */

            //Задание 12

            Console.Write("Введите 1 число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3 число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int sumchik = 0;
            if (num1 > 0)
            {
                sumchik += num1;
            }
            if (num2 > 0)
            {
                sumchik += num2;
            }
            if (num3 > 0)
            {
                sumchik += num3;
            }
            Console.WriteLine($"Сумма: {sumchik}");
        }
    }
}
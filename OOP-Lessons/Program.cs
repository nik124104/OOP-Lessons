using System;

namespace OOP_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание!");
            Console.WriteLine("Lesson2");
            Console.Write("Запусть дамашне задание №");
            string lesson= Console.ReadLine();
            

            

            switch (lesson)
            {
                case "2":
                    Log.Logs("Выбран Lesson2");
                    Console.WriteLine("Выбран Lesson2");
                    Banks.Bank();

                    break;

                    Console.WriteLine("the end");
            }

        }
    }
}

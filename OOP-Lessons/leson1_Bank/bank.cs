using OOP_Lessons.leson1_Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lessons
{
    public class Banks
    {
        private static int newid = 0; //порядковый номер счета
        //private static var checks;
        public static void Bank()
        {
            int n = 0;

            double money;


            var checks = new List<Check>();
            var check = new Check();
            checks.Add(check);

            Console.WriteLine("Меню Банка:\n 1)Создать счет\n 2)Пополнить счет\n 3)Списать средства\n 4)Просмотр баланса:\n 5)Выйти \nВыберете пункт меню:");
            do
            {
                int.TryParse(Console.ReadLine(), out n);

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Создание нового счета");
                        newid++;
                        // NewCheck(newid); //Пытался вписать код в метод, но что то пошло не так)),
                        // промучился долго...
                        // Проблема была в том что не смог вынести  List<Check> на весь класс
                        {
                            double money = -1;
                            int tipe = -1;
                            do
                            {


                                Console.Write("Введите сумму - ");
                                // money = Convert.ToDouble(Console.ReadLine());
                                if (double.TryParse(Console.ReadLine(), out money) & money >= 0)
                                {
                                    Log.Logs($"Принято money={money}");
                                }
                                else
                                {
                                    Console.WriteLine("Введите коректную сумму больше 0");
                                    money = -1;
                                }
                                Console.Write("Введите тип счета 1)Classic, 2)salary, 3)credit ");
                                //int tipe = Convert.ToInt32(Console.ReadLine());

                                if (int.TryParse(Console.ReadLine(), out tipe) & tipe > 0 & tipe < 4)
                                {
                                    Log.Logs($"Принято Тип счета={tipe}");
                                }
                                else
                                {
                                    Console.WriteLine("Введите коректную сумму больше 0");
                                    money = -1;
                                }

                            } while (money > 0 & tipe > 0 & tipe < 4);



                            check = new Check(1000 + newid, money, tipe);
                            checks.Add(check);
                        }
                        break;
                    case 2:

                        Console.WriteLine("Пополнение счета");
                        Console.Write("Введите номер счета");

                        {
                            int idcheck;

                            idcheck = ID();
                            var id1 = checks.FirstOrDefault(u => u.idcheck == idcheck);

                            if (id1.idcheck == idcheck)///Не забыть посмотреть
                            {
                                Console.Write("Введите сумму пополнения + ");

                                if (double.TryParse(Console.ReadLine(), out money) & money > 0)
                                {
                                    Log.Logs($"Принято money={money}");
                                }
                                else
                                {
                                    Console.WriteLine("Вы вели не коректную сумму пополнения");
                                    money = 0;

                                }

                                if (money > 0)
                                {
                                    id1.balanse += money;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Счет не найден");
                            }

                            Console.WriteLine("Выход в главное меню банка");

                        }
                        break;
                    case 3:
                        {
                            int idcheck;
                            Console.WriteLine("Списание средств");
                            idcheck = ID();
                            var id2 = checks.FirstOrDefault(u => u.idcheck == idcheck);


                            if (id2.idcheck == idcheck) ///Не забыть посмотреть!!!
                            {
                                Console.Write("Введите сумму пополнения - ");

                                money = MOney();

                                if (money > 0)
                                {
                                    id2.balanse -= money;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Счет не найден");
                            }


                        }
                        break;
                    case 4:
                        {
                            int idcheck;
                            Console.WriteLine("Списание средств");
                            idcheck = ID();
                            var id3 = checks.FirstOrDefault(u => u.idcheck == idcheck);

                            if(id3.idcheck == idcheck)
                            {
                                Console.WriteLine(id3.balanse);
                            }
                            else 
                            {
                                Console.WriteLine("Счет не найден");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Выход в главное меню.");
                        
                        break;
                    default:
                        Console.WriteLine("Введите пункт меню от 1-5");
                        break;

                }
            } while (n == 5);

        }

        static int ID()
        {
            bool flag = true;
            int idcheck;
            do
            {

                if (int.TryParse(Console.ReadLine(), out idcheck))
                {
                    Log.Logs($"Принято номер счета={idcheck}");
                }
                else
                {
                    Console.WriteLine("Введите коректно номер счета в формате ХХХХ");
                    flag = false;
                }
            } while (flag == true);

            return idcheck;
        }


        static double MOney()
        {

            double money;
            if (double.TryParse(Console.ReadLine(), out money) & money > 0)
            {
                Log.Logs($"Принято money={money}");
            }
            else
            {
                Console.WriteLine("Вы вели не коректную сумму списания");
                money = 0;

            }
            return money;

        }

        static void NewCheck(int newid)
        {
            double money=-1;
            int tipe = -1;
            do
            {


                Console.Write("Введите сумму - ");
                // money = Convert.ToDouble(Console.ReadLine());
                if (double.TryParse(Console.ReadLine(), out money) & money >= 0)
                {
                    Log.Logs($"Принято money={money}");
                }
                else
                {
                    Console.WriteLine("Введите коректную сумму больше 0");
                    money = -1;
                }
                Console.Write("Введите тип счета 1)Classic, 2)salary, 3)credit ");
                //int tipe = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(Console.ReadLine(), out tipe) & tipe > 0 & tipe < 4)
                {
                    Log.Logs($"Принято money={money}");
                }
                else
                {
                    Console.WriteLine("Введите коректную сумму больше 0");
                    money = -1;
                }

            } while (money > 0 & tipe > 0 & tipe < 4);

            
            //var checks = new List<Check>();
            //var check = new Check(1000 + newid, money, tipe);


            ////var check = new Check() { balanse = 100, idcheck=10 };
            //checks.Add(check);


        }

        static void View()
        {
            //Console.WriteLine(

        }
        

        }
    }
}

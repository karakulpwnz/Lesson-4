using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Володин Артем
//
//3. Решить задачу с логинами из предыдущего урока, 
//только логины и пароли считать из файла в массив. 
//Создайте структуру Account, содержащую Login и Password.
//4. Реализовать метод проверки логина и пароля.На вход 
//подается логин и пароль.На выходе истина, если прошел авторизацию, 
//и ложь, если не прошел (Логин: root, Password: GeekBrains). 
//Используя метод проверки логина и пароля, написать программу: пользователь вводит 
//логин и пароль, программа пропускает его дальше или не пропускает.С помощью 
//цикла do while ограничить ввод пароля тремя попытками.

namespace Task_3
{
    struct Account
    {
        public string login;
        public string pass;
    }

    class Program
    {
        private static bool Check(string UserLogin, string UserPass, string login, string pass)
        {
            if (UserLogin == login & UserPass == pass)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        static void Main(string[] args)
        {
            Account verify = new Account();
            verify.login = "root";
            verify.pass = "GeekBrains";

            StreamReader sr = new StreamReader("..\\..\\accounts.txt");

            string[,] accs = new string[3, 2];

            int counter = 0;
            do
            {
                
                accs[counter, 0] = sr.ReadLine();
                Console.WriteLine("\nВведите логин: " + accs[counter, 0]);
                accs[counter, 1] = sr.ReadLine();
                Console.WriteLine("Введите пароль: " + accs[counter, 1]);


                if (Check(accs[counter, 0], accs[counter, 1], verify.login, verify.pass) == false & counter < 3)
                {
                    Console.WriteLine("\nЛогин и пароль НЕверны." +
                   "\nУ вас осталось " + (2 - counter) + " попыток.");
                }
                else if (Check(accs[counter, 0], accs[counter, 1], verify.login, verify.pass) == true)
                {
                    Console.WriteLine("\nЛогин и пароль верны.");
                    break;
                }
                else if (counter == 2)
                {
                    Console.WriteLine("\n" +
                  "Логин и пароль НЕверны." +
                  "\nУ вас не осталось попыток.");
                }
                counter++;
            } while (counter < 3);

            Console.ReadLine();



        }
    }
}

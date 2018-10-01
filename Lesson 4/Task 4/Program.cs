using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Володин Артем
//
//4. *а) Реализовать класс для работы с двумерным массивом. 
//Реализовать конструктор, заполняющий массив случайными числами. 
//Создать методы, которые возвращают сумму всех элементов массива, 
//сумму всех элементов массива больше заданного, свойство, 
//возвращающее минимальный элемент массива, свойство, возвращающее 
//максимальный элемент массива, метод, возвращающий номер максимального 
//элемента массива (через параметры, используя модификатор ref или out)

namespace Task_4
{
    class TwoDemArray
    {
        int[,] a;
        
        public TwoDemArray(int n, int k, int min, int max)
        {
            a = new int[n,k];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                    a[i,j] = rnd.Next(min, max);
            }
        }
        // Сумма всех элементов массива
        public int Summ()
        {
            int summ = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    summ = summ + a[i, j];
            }

            return summ;
        }
        // Сумма всех элементов массива, больше заданного
        public int SummBigger(int n)
        {
            int summ = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > n)
                    {
                        summ = summ + a[i, j];
                    }
                }
            }

            return summ;
        }
        // Вывод минимального элемента массива
        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min)
                        {
                            min = a[i, j];
                        }
                    }
                }

                return min;
            }
        }
        // Вывод максимального элемента массива
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }
                }

                return max;
            }
        }
        // Номер максимального элемента
        public void Number (int max, ref int i1, ref int j1)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == max)
                    {
                        i1 = i;
                        j1 = j;
                    }
                }
            }  
        }
        // Вывод массива в строку
        public string ToString
        {
            get
            {
                string s = "";

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        s = s + a[i, j] + " ";
                    s = s + "\n";
                }

                return s;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TwoDemArray array = new TwoDemArray(3, 3, 0, 10);
            Console.WriteLine("Массив:\n" + array.ToString);
            Console.WriteLine("Сумма всех элементов: " + array.Summ());
            Console.WriteLine("Сумма всех элементов, больше 5: " + array.SummBigger(5));
            Console.WriteLine("Минимальный элемент: " + array.Min);
            Console.WriteLine("Максимальный элемент: " + array.Max);
            int i = 0;
            int j = 0;
            array.Number(array.Max, ref i, ref j);
            Console.WriteLine("Номер максимального элемента: a[" + i + "," + j + "]");


            Console.ReadLine();
        }
    }
}

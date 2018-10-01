using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Володин Артем
//
//2. а) Дописать класс для работы с одномерным массивом. 
//Реализовать конструктор, создающий массив заданной размерности и 
//заполняющий массив числами от начального значения с заданным шагом. 
//Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, 
//меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива 
//на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
//В Main продемонстрировать работу класса.
//б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

namespace Task_2
{
    class MyArray
    {
        int[] a;
        // Создание массива и заполнение его одним значением el
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        // Создание массива и заполнение его случайными элементами от min до max
        public MyArray(int n, int min, int max, int blank)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        // Создание массива и заполнение его числами от начального значения с заданным шагом
        public MyArray(int n, int first, int incriment)
        {
            a = new int[n];
            a[0] = first;
            for (int i = 1; i < n; i++)
                a[i] = a[i - 1] + incriment;
        }
        // Сумма элементов массива
        public int Summ()
        {
            int summ = 0;
            for (int i = 0; i < a.Length; i++)
                summ = summ + a[i];
            return summ;
        }
        // Изменение знака 
        public int[] Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                    a[i] = -a[i];
            }
            return a;
        }
        // Умножение элементов на заданное число
        public void Multi(int k)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = a[i] * k;
        }
        // Число максимальных элементов
        public int MaxCount()
        {
            int count = 1;
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    count = 1;
                    max = a[i];
                }
                else if (a[i] == max)
                {
                    count++;
                }
                
            }

            return count;
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, -5, 5, 0);
            Console.WriteLine("Массив: " + a.ToString());
            Console.WriteLine("Сумма всех элементов массива: " + a.Summ());
            Console.WriteLine("Максимальное число: " + a.Max);
            Console.WriteLine("Минимальное число: " + a.Min);
            Console.WriteLine("Количество положительных значений: " + a.CountPositiv);
            Console.WriteLine("Число максимальных элементов: " + a.MaxCount());

            a.Inverse();
            Console.WriteLine("\nМассив с противоположным знаком элементов: " + a.ToString());
            a.Inverse();

            a.Multi(5);
            Console.WriteLine("Умножение элементов на заданное число (для примера взято число 5): " + a.ToString());

            Console.ReadLine();
        }
    }}
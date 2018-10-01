using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Володин Артем
//
//1. Дан целочисленный массив из 20 элементов. 
//Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
//Написать программу, позволяющую найти и вывести количество пар элементов массива, 
//в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается 
//два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];

            Console.Write("Массив: ");

            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10000, 10000);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();

            int summ = 0;

            for(int i = 0; i < (a.Length-1); i++)
            {
                if (a[i] % 3 == 0)
                {
                    summ++;
                    Console.WriteLine("Первая пара: " + a[i] + " и " + a[i + 1]);
                } else if (a[i+1] % 3 == 0)
                {
                    summ++;
                    Console.WriteLine("Первая пара: " + a[i] + " и " + a[i + 1]);
                }
            }

            Console.WriteLine("\nВсего пар чисел: " + summ);
            Console.ReadLine();

        }
    }
}

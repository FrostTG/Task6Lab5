using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Введите число [{0},{1}] для массива", i, j);
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine();
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Про магический куб нашел в интернете как люди пишут, сам никак не мог понять принцип работы данного массива, попытался подставить значения под свою работу
            int[] array = new int[(2 * N + 2)]; //<= вот это в первую очередь не понятно, почему 2*n+2? если, допустим N=3, то одномерный массив будет из 8 чисел?
                                                //А как это связать с 2-мерным массивом у которого при N=3 чисел будет 9, а если N Больше то рассхождение еще больше будет
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i] += mas[i, j];
                    array[i + N] += mas[i, j];
                }
            }
            for (int j = 0; j < N; j++)
            {
                array[0 + 2 * N] += mas[j, j];
                array[1 + 2 * N] += mas[j, (N - j - 1)]; //тут тоже лес для меня с диагоналями, я самого принципа не понимаю кажется(
            }
            bool f = true;
            for (int i = 1; i < array.Length; i++) //с проверкой условий вроде как понятно, не считая того что мы Lenght на момент 5 Занятия еще не проходили.
            {
                if (array[0] != array[i])
                {
                    f = false;
                    break;
                }
            }
            if (f == false)
                Console.WriteLine("Матрица не является магическим квадратом");
            else
                Console.WriteLine("it's a MAGIC CUBE!!");
            Console.ReadKey();
        }
    }
}

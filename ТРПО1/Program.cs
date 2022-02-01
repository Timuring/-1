using System;

namespace ТРПО1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int sum = 0;
            int num = 0;
            int zxc = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            Random rnd = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < N; i++)
            {
                mas[i] = rnd.Next(-10, 11);
                Console.Write(mas[i] + " ");
            }
            for (int i = 0; i < N; i++)
            {
                if (mas[i] < 0)
                    sum++;
                if (mas[i] == 0)
                    num = num + 1;
                if (mas[i] > 0)
                    zxc = zxc + 1;

            }
            Console.WriteLine("Кол-во отрицательных чисел: " + sum);
            Console.WriteLine("Кол-во положительных чисел: " + zxc);
            Console.WriteLine("Кол-во нулевых значений: " + num);
        }
    }
}
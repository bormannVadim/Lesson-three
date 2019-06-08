using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_two
{
    class Program
    {
        static void Main(string[] args)
        {
            //Савенко

            Console.WriteLine("Вводите числа, пока не введёте 0 !");
            int nextNum;
            bool flag;
            int sum = 0;
            do
            {
                do
                {
                  flag = int.TryParse(Console.ReadLine(), out nextNum);
                } while (!flag);
                if (nextNum % 2 != 0 && nextNum > 0)
                    sum += nextNum;
            }
            while (nextNum !=0);

            Console.WriteLine("Сумма нечётных положительных: " + sum);

            
        }

     
    }
}

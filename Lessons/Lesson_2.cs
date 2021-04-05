using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public class Lesson_2
    {
        public void Do()
        {
            //3! = 1 * 2 * 3 = ???
            //125! = 1 * 2 ... * 125

            int sum = 1;
            for (int i = 1; i <= 3; i++)
            {
                sum = sum * i;
                Console.WriteLine("I: " + i);
            }
            Console.WriteLine("SUM: " + sum);

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 1; j <= 3; j++)
                {
                    Console.WriteLine("I: " + i + " J: " + j);
                }
                Console.WriteLine("");
            }
            // [1, 1, 0, 1, 0, 0] = 1D

            // [1, 2, 3] - 1 ряд, в нем 3 элемента (1, 2, 3). Где 1 - первый элемент, 2 - второй и т.д.
            // [1, 2, 3]
            // [1, 2, 3]
            // 2D матрица
            //

            //Д.з.
            //Нарисовать с помощью циклов матрицу
            // * * *
            // * * *
            // * * *

            Console.Write("123 \n"); //\n - символ перехода на новую строку.
            
        }
    }
}

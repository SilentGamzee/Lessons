using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static int int_1 = 123, int_2 = 111;  //Целые числа - 1,2,200,1000,124125
        static float f = 1.0f; //Дробные числа - 1.123, 0.66, 1.0
        static string t = "text"; //Текст - "123", "asdf", "text"
        static bool boolean = true; //Да или Нет

        //Entry point - точка входа
        static void Main(string[] args)
        {
            //Lesson 1
            int x = 2, y = 3;
            var sumXY = x + y;

            float f_x = 2.5f, f_y = 3.5f;
            var f_symXY = f_x + f_y;

            string s_x = "start_", s_y = "end_";
            var s_sumXY = s_x + s_y;
            Console.WriteLine("s_sumXY: "+ s_sumXY);

            bool b_x = false, b_y = true;
            var b_sumXY = b_x == b_y;

            //Lesson 2
            Lesson_2 lesson_2 = new Lesson_2();
            lesson_2.Do();

            Console.ReadLine();
        }
    }
}

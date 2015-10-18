using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    class Problem17
    {
        static int[] letCones = {0, 3, 3, 5, 4, 4, 3, 5, 5, 4 };
        static int[] letCteens = {3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
        static int[] letCtys = { 0, 0, 6, 6, 5, 5, 5, 7, 6, 6};
        static int hundred = 7;
        static int and = 3;
        static int thousand = 8;
        public static void Run()
        {

            int letCount = 0;
            //letCount = LetterCount(15);
            for (int i = 1; i < 1000; i++)
           {
               letCount += LetterCount(i);

           }
            letCount += letCones[1] + thousand;
            Console.WriteLine(letCount);
        }
        static int LetterCount(int number)
        {
            if (number == 0)
                return 0;
            int curLetCount = 0;
            if(number/100>0)
            {
                curLetCount = letCones[number / 100] + hundred;
                if (number > ((number / 100) * 100))
                    curLetCount += and + LetterCount(number % 100);
            }
            else if(number/10 > 0)
            {
                if (number / 10 == 1)
                    curLetCount = letCteens[number % 10];
                else
                {
                    curLetCount = letCtys[number / 10] + LetterCount(number % 10);
                }
            }
            else
            {
                curLetCount += letCones[number];
            }
            return curLetCount;
        }
    }
}

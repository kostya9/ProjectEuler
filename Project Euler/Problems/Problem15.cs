using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    class Problem15
    {
        public static void Run()
        {
            Small();
            Console.ReadKey();
        }
        static void Small()
        {
            int[] first = new int[20];
            int[] second = new int[20];
            for(int i = 1; i<=20; i++)
            {
                first[i-1] = 20 + i;
                second[i - 1] = i;
                if (first[i - 1] % second[i - 1] == 0 && i != 1)
                {
                    first[i - 1] /= second[i - 1];
                    second[i - 1] = 1;
                }
            }
            for(int i = 1; i<20;i++)
                for(int g = 0; g<20; g++)
                {
                    if (first[i] % second[g] == 0)
                    {
                        first[i] /= second[g];
                        second[g] = 1;
                    }
                    }
            long multy = 1;
            foreach (int i in first)
                multy *= i;
            long multy1 = 1;
            foreach (int i in second)
                multy1 *= i;
            Console.WriteLine(multy / multy1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    class Problem16
    {
        public static void Run()
        {
            List<int> digits = new List<int>();
            digits.Add(1);
            digits.Add(0);
            for(int i = 1; i<=1000; i++)
            {
                if (i == 1)
                    i += 0;
                int count = digits.Count;
                for (int g = 0; g < count; g++)
                {
                    digits[g] *= 2;
                }
                RearrangeList(digits);
            }
            int sum = 0;
            foreach (int i in digits)
                sum += i;
            Console.WriteLine(sum);

        }
        static void RearrangeList(List<int> digits)
        {
            int count = digits.Count;
            int n = 0;
            while (n<count+1)
            {
                if (n + 1 > digits.Count-1)
                    digits.Add(0);
                if (digits[n] >= 10)
                {
                    int biggest = digits[n] / (int)Math.Pow(10, digits[n].ToString().Count() - 1);
                    digits[n + 1] += biggest;
                    digits[n] = digits[n] - biggest * (int)Math.Pow(10, digits[n].ToString().Count() - 1);
                }
                else if (digits[n] < 10)
                {
                    if (n + 2> digits.Count-1)
                        digits.Add(0);
                    n++;
                }    

            }
            for(int i = digits.Count-1; ;i--)
            {
                if (digits[i] == 0)
                    digits.RemoveAt(i);
                else
                    break;
            }
        }

    }
}

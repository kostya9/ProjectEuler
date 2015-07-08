using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    sealed class Problem10
    {
        public static void Run(int under)
        {
            long sum = 0;
            foreach(int i in FindAllPrimeMultiplyersUnder(under))
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        public static List<int> FindAllPrimeMultiplyersUnder(int n)
        {

            List<int> primes = new List<int>();
            if (n > 2)
                primes.Add(2);
            for (int i = 3; i < n; i+=2)
            {
                bool prime = true;
                foreach (int g in primes)
                {
                    int curnum = i;
                    if (g > Math.Sqrt(i))
                        break;
                    if (i % g == 0)
                    {
                        prime = false;
                        while (curnum % g == 0)
                            curnum /= g;
                    }
                }
                if (prime)
                    primes.Add(i);

            }
            return primes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    class Problem12
    {
        static List<int> primeMultis;
        public static void Run()
        {
            int sum = 1;
            primeMultis = new List<int>();
            for (int i = 2; ;i++)
            {
                sum += i;
                if (for() > 5)
                    break;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        public static Dictionary<int, int> FindAllMultiplyersOf(int n)
        {
            Dictionary<int, int> primes = new Dictionary<int, int>();
            bool isPrime = true;
            foreach (int prime in primeMultis)
            {
                if ((n % prime) == 0)
                {
                    isPrime = false;
                    int g = 0;
                    while ((n % prime) == 0)
                    {
                        g++;
                        n /= prime;
                    }
                    primes.Add(prime, g);
                }
            }
            if (isPrime)
                primes.Add(n, 1);
            return primes;
           
        }
        static int Factorize(int given)
        {
            int f = 1;
            for (int i = 2; i <= given; i++)
                f *= i;
            return f;
                
        }
    }
}

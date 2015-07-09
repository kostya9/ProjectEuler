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
            for (int i = 2; ; i++)
            {
                Dictionary<int, int> newDic = new Dictionary<int, int>();
                int g = 1;
                sum += i;
                foreach (var n in FindAllMultiplyersOf(i))
                {
                    
                    if (newDic.ContainsKey(n.Key))
                        newDic[n.Key] += n.Value;
                    else
                        newDic[n.Key] = n.Value;
                }
                foreach (var n in FindAllMultiplyersOf(i + 1))
                {
                    if (newDic.ContainsKey(n.Key))
                        newDic[n.Key] += n.Value;
                    else
                        newDic[n.Key] = n.Value;
                }
                foreach (var n in newDic)
                    if (n.Key == 2)
                        g *= n.Value;
                    else
                        g *= n.Value + 1;
                if (g > 500)
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
            {
                primes.Add(n, 1);
                primeMultis.Add(n);
            }
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

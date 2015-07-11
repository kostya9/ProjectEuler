using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problems
{
    class Problem14
    {
        static long chainLength = 0;
        static Dictionary<long, long> intToChainLength = new Dictionary<long, long>();
        public static void Run()
        {
            for (long n = 1; n < 1000000; n++)
            {
                List<long> chain = new List<long>();
                chainLength = 0;
                colltzDo(n, chain);
            }
            long max = intToChainLength.Values.Max();
            long key = 0;
            foreach(var i in intToChainLength)
            {
                if (i.Value == max)
                    key = i.Key;
            }
            Console.WriteLine(key);
            Console.ReadLine();
        }
        static void colltzDo(long n, List<long> chainTemp)
        {
            checked
            {
                if (intToChainLength.Keys.Contains(n))
                {
                    for (int i = 0; i < chainTemp.Count; i++)
                    {
                        if (intToChainLength.Keys.Contains(chainTemp[i]))
                            return;
                        intToChainLength.Add(chainTemp[i], chainTemp.Count - i + intToChainLength[n]);
                    }
                    return;
                }
                chainTemp.Add(n);
                chainLength++;
                if (n == 1)
                {
                    for (int i = 0; i < chainTemp.Count; i++)
                    {
                        if (intToChainLength.Keys.Contains(chainTemp[i]))
                            return;
                        intToChainLength.Add(chainTemp[i], i + 1);
                    }
                    return;
                }
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = 3 * n + 1;
            }
            colltzDo(n, chainTemp);
        }
    }
}

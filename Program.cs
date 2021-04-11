using System;

namespace TwinPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 75;
            int[] lastPrime = new int[] { };

            int input;
            if (args.Length > 0 && int.TryParse(args[0], out input))
                start = input;
            if (args.Length > 1 && int.TryParse(args[1], out input))
                end = input;

            Console.WriteLine($"\nfind all prime and twin prime numbers between {start} and {end}");

            //its prime time
            for (int i = start; i < end; i++)
            {
                if (i < 2)
                {
                    continue;
                }

                if (i == 2)
                {
                    Array.Resize(ref lastPrime, lastPrime.Length + 1);
                    lastPrime[lastPrime.Length - 1] = i;
                    continue;
                }

                if (lastPrime[lastPrime.Length - 1] > 1)
                {
                    if (i % 2 == 1)
                    {
                        for (int j = 0; j < lastPrime.Length; j++)
                        {
                            if (i % lastPrime[j] != 1 && i % lastPrime[j] != 2)
                                continue;

                            foreach (int prime in lastprime)
                            {
                                if (prime != lastPrime[lastPrime.Length])
                                {

                                }
                            }

                            Array.Resize(ref lastPrime, lastPrime.Length + 1);
                            lastPrime[lastPrime.Length - 1] = i;
                            break;
                        }
                    }
                }
            }

            for (int i = start; i < lastPrime.Length; i++)
            {
                Console.WriteLine($"\n{lastPrime[i]},");
            }
        }
    }
}
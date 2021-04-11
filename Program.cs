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

            if (end < start)
            {
                Console.WriteLine("Error: upper bound should not be smaller then the lower bound");
                Environment.Exit(0);
            }
            else if (start < 0 || end < 0)
            {
                Console.WriteLine("Error: upper or lower bound can't be less then 0");
                Environment.Exit(0);
            }

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
                        bool isprime = true;
                        for (int j = 0; j < lastPrime.Length; j++)
                        {
                            if (i % lastPrime[j] != 1 && i % lastPrime[j] != 2)
                                continue;

                            foreach (int prime in lastPrime)
                            {
                                if (prime != lastPrime[lastPrime.Length - 1])
                                {
                                    if (i % prime == 0)
                                    {
                                        isprime = false;
                                    }
                                }
                            }

                            if (!isprime)
                                continue;

                            Array.Resize(ref lastPrime, lastPrime.Length + 1);
                            lastPrime[lastPrime.Length - 1] = i;
                            break;
                        }
                    }
                }
            }

            for (int i = start + 1; i < lastPrime.Length; i++)
            {
                if (lastPrime[i] - lastPrime[i - 1] == 2)
                    Console.WriteLine("\n" + lastPrime[i - 1] + ", " + lastPrime[i]);
            }
        }
    }
}